using TcpChatClient.Controllers;

namespace TcpChatClient
{
  public partial class ClientForm : Form, IClient
  {
    private ClientController _cont = null!;

    private void SendMessage()
    {
      _cont.Send(txtMessage.Text.Trim());
    }

    private void ClientForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
      _cont.DisConnect();
    }

    public void SetController(ClientController controller)
    {
      _cont = controller;
    }

    private void btnSendMessage_Click(object sender, EventArgs e)
    {
      SendMessage();
    }

    private void txtMessage_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) SendMessage();
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      string ip = txtIp.Text;
      if (int.TryParse(txtPort.Text, out int port))
      {
        _cont.SetNickName(txtNickName.Text);
        _cont.Start(ip, port);
      }
    }

    public ClientForm()
    {
      InitializeComponent();

      FormClosed += ClientForm_FormClosed;
    }

    public void DisplayMessage(string message)
    {
      this.Invoke(() =>
      {
        txtChat.AppendText($"{message}\n");
        txtMessage.Clear();
      });
    }
  }
}