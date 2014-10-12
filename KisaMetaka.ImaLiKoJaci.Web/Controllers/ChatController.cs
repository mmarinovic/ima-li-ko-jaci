using System.Web;
using System.Web.Http;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Services;
using KisaMetaka.ImaLiKoJaci.Web.Hubs;
using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class ChatController : ApiController
    {
        private readonly ILoginService _loginService;

        public ChatController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public void SendAnswer(SendAnswerModel model)
        {
            var user = _loginService.TryGetSignedInUser();
            if (user == null) { throw new HttpException(403, "User not logged in."); }

            var messageModel = new MessageModel(user, model.Answer, MessageType.UserAnswer);

            PublicHub.SendMessage(messageModel);
        }
    }
}
