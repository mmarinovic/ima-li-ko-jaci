using System.Web.Hosting;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;
using KisaMetaka.ImaLiKoJaci.Web.Timers;

namespace KisaMetaka.ImaLiKoJaci.Web.Helpers
{
    public static class ChatLogicHelper
    {
        private static ChatLogicTimer _timer;

        public static void RegisterTimer()
        {
            _timer = new ChatLogicTimer();

            HostingEnvironment.RegisterObject(_timer);
        }

        public static void StopTimer()
        {
            _timer.Stop(true);
        }

        public static void SendCurrentRoundInfo(string connectionId = null)
        {
            _timer.SendCurrentRoundInfo(connectionId);
        }

        public static bool CheckWinningAnswer(string answer, UserDto user)
        {
            return _timer.CheckWinningAnswer(answer, user);
        }

        public static void AwardPointsAndAnnounceWinner(string answer, UserDto user)
        {
            _timer.AwardPointsAndAnnounceWinner(answer, user);
        }
    }
}