using System.Threading.Tasks;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Services;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;
using KisaMetaka.ImaLiKoJaci.Web.Helpers;
using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using StructureMap;

namespace KisaMetaka.ImaLiKoJaci.Web.Hubs
{
    [HubName("publicChat")]
    public class PublicHub : Hub
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoginService _loginService;
        private readonly IHubConnectionsStorage _hubConnectionsStorage;

        private readonly UserDto _botUser;
        public PublicHub()
        {
            _userRepository = ObjectFactory.GetInstance<IUserRepository>();
            _loginService = ObjectFactory.GetInstance<ILoginService>();
            _hubConnectionsStorage = ObjectFactory.GetInstance<IHubConnectionsStorage>();

            _botUser = _userRepository.GetBot();
        }

        public override Task OnConnected()
        {
            AddUserToConnectionStorage();
            UpdateConnectionsInfo();

            var welcomeMessage = CreateWelcomeMessageForUser();
            var userArrivalMessage = CreateUserArivalNotification();
           
            SendMessage(welcomeMessage, Context.ConnectionId);
            SendMessage(userArrivalMessage);

            ChatLogicHelper.SendCurrentRoundInfo(Context.ConnectionId);

            return base.OnConnected();
        }

        public override Task OnReconnected()
        {
            AddUserToConnectionStorage();
            UpdateConnectionsInfo();
            return base.OnReconnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            _hubConnectionsStorage.Remove(Context.ConnectionId);
            UpdateConnectionsInfo();

            return base.OnDisconnected(stopCalled);
        }

        private void UpdateConnectionsInfo()
        {
            var currentConnections = _hubConnectionsStorage.GetConnectedUsers();
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();

            hubContext.Clients.All.UpdateConnectionsInfo(currentConnections);
        }

        public static void SendMessage(MessageModel model, string connectionId = null)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();

            if (string.IsNullOrEmpty(connectionId))
            {
                hubContext.Clients.All.sendMessage(model);
            }
            else
            {
                hubContext.Clients.Client(connectionId).sendMessage(model);
            }
        }

        private MessageModel CreateWelcomeMessageForUser()
        {
            return new MessageModel(
                _botUser, 
                "Dobar dan dobra večer, batman u usta ti ga metnem, mečem",
                MessageType.Info
            );
        }

        private MessageModel CreateUserArivalNotification()
        {
            var signedInUser = _loginService.TryGetSignedInUser();
            var userDisplayName = signedInUser == null
                ? _userRepository.GetAnonymous().DisplayName
                : signedInUser.DisplayName;

            return new MessageModel(
                _botUser, 
                string.Format("{0} se priključio!", userDisplayName),
                MessageType.UserArrival
           );
        }

        private void AddUserToConnectionStorage()
        {
            var user = _loginService.TryGetSignedInUser() ?? _userRepository.GetAnonymous();

            _hubConnectionsStorage.Add(user, Context.ConnectionId);
        }
    }
}