using System.Web.Http;
using KisaMetaka.ImaLiKoJaci.Web.Hubs;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class ChatController : ApiController
    {
        [HttpPost]
        public void SendAnswer([FromBody] string answer)
        {
            PublicHub.SendAnswer(answer);
        }
    }
}
