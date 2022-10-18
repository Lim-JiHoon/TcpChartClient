using TcpChatLib.Models;
using System.Net.Sockets;
using TcpChatLib.Utils;
using TcpChatLib.Extensions;

namespace TcpChatClient.Controllers
{
  public class ClientController
  {
    private IClient _view;
    private Socket? _socket;
    private Thread? _receiveThread;
    private ChatInfo _chatInfo;
    private bool IsConnected => _socket != null && _socket.IsConnected();
    private void Receive()
    {
      while (true)
      {
        // 연결된 클라이언트가 보낸 데이터 수신
        byte[] buffer = new byte[1024];

        try
        {
          int length = _socket!.Receive(buffer, buffer.Length, SocketFlags.None);
          ChatInfo chatInfo = JsonUtils.DeserializeByBytes(buffer)!;
          _view.DisplayMessage($"{chatInfo.NikName}: {chatInfo.Message}");
        }
        catch (SocketException ex)
        {
          Console.WriteLine(ex.ErrorCode);
          _view.DisplayMessage(ex.Message);
          break;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          break;
        }
      }
    }

    public ClientController(IClient view)
    {
      _view = view;
      _view.SetController(this);
      _chatInfo = new ChatInfo();
    }

    internal void Start(string ip, int port)
    {
      if (!IsConnected)
      {

        try
        {
          _socket = SocketUtils.Connect(ip, port);
          _socket?.SendMsgWithSerialize(new ChatInfo() { NikName = _chatInfo.NikName, ComeIn = true }, "");
        }
        catch (Exception ex)
        {
          if (((dynamic)ex).ErrorCode == 10061)
          {
            MessageBox.Show("소켓 서버가 실행되지 않았습니다.!!");
            return;
          }
        }

        _receiveThread = new(new ThreadStart(Receive));
        _receiveThread.Start();
      }
    }

    internal void Send(string message)
    {
      if (!IsConnected)
      {
        MessageBox.Show("소켓이 연결되지 않았습니다.!!");
        return;
      }

      _socket!.SendMsgWithSerialize(_chatInfo, message);
    }

    public void DisConnect()
    {
      _socket!.SendMsgWithSerialize(_chatInfo, "");
      if (_socket?.Connected == true)
      {
        try
        {
          _socket?.Disconnect(false);
        }
        catch { }
      }
      _socket?.Close();
    }
    public void SetNickName(string nickName)
    {
      _chatInfo.NikName = nickName;
    }
  }
}
