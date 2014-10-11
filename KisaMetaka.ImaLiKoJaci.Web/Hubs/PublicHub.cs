using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace KisaMetaka.ImaLiKoJaci.Web.Hubs
{
    [HubName("publicChat")]
    public class PublicHub : Hub
    {
        public static void ShowNewQuestion(string question)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.showNewQuestion(question);
        }

        public static void ShowCorrectAnswer(string winnerDisplayName, string answer)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.showCorrectAnswer(winnerDisplayName, answer);
        }

        public static void SendAnswer(string userFacebookId, string answer)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PublicHub>();
            hubContext.Clients.All.showAnswer(userFacebookId, answer);
        }
    }
}