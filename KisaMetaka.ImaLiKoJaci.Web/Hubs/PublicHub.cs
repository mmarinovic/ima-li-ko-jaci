using System.Threading.Tasks;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;
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
        private readonly UserDto _botUser;
        public PublicHub()
        {
            _userRepository = ObjectFactory.GetInstance<IUserRepository>();

            _botUser = _userRepository.TryGet("bot");
        }
        public override Task OnConnected()
        {
            var welcomeMessage = new MessageModel(_botUser, "Dobar dan dobra večer, batman u usta ti ga metnem, mečem", MessageType.Info);

            SendMessage(Context.ConnectionId, welcomeMessage);
           
            return base.OnConnected();
        }

        public static void SendMessage(string connectionId, MessageModel model)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.Client(connectionId).sendMessage(model);
        }
        public static void SendMessage(MessageModel model)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.sendMessage(model);
        }
    }
}