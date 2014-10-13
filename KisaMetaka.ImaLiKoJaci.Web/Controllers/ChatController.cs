using System.Web.Http;

using KisaMetaka.ImaLiKoJaci.Infrastructure.Services;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;
using KisaMetaka.ImaLiKoJaci.Web.Helpers;
using KisaMetaka.ImaLiKoJaci.Web.Hubs;
using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class ChatController : ApiController
    {
        private readonly ILoginService _loginService;
        private readonly IUserRepository _userRepository;

        public ChatController(
            ILoginService loginService,
            IUserRepository userRepository)
        {
            _loginService = loginService;
            _userRepository = userRepository;
        }

        [HttpPost]
        public void SendAnswer(SendAnswerModel model)
        {
            var user = _loginService.TryGetSignedInUser();

            if (user != null)
            {
                var isWinningAnswer = ChatLogicHelper.CheckWinningAnswer(model.Answer, user);
                if (isWinningAnswer)
                {
                    ChatLogicHelper.AwardPointsAndAnnounceWinner(model.Answer, user);
                    return;
                }
            }
            else
            {
                user = _userRepository.GetAnonymous();
            }

            var messageModel = new MessageModel(user, model.Answer, MessageType.UserAnswer);

            PublicHub.SendMessage(messageModel); 
        }
    }
}
