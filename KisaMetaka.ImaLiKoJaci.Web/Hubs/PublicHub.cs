using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace KisaMetaka.ImaLiKoJaci.Web.Hubs
{
    [HubName("publicChat")]
    public class PublicHub : Hub
    {
        public static void SendMessage(MessageModel model)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.sendMessage(model);
        }
    }
}