using System.Web.Http;
using KisaMetaka.ImaLiKoJaci.Web.Hubs;
using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class ChatController : ApiController
    {
        [HttpPost]
        public void SendAnswer(SendAnswerModel model)
        {
            PublicHub.SendAnswer(model.Answer);
        }
    }
}
