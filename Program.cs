using TcpChatClient.Controllers;

namespace TcpChatClient
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      ClientForm frm = new();
      ClientController cont = new(frm);
      Application.Run(frm);
    }
  }
}