using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcpChatLib;

namespace TcpChatClient.Controllers
{
  public interface IClient: IMainView
  {
    void SetController(ClientController controller);
  }
}
