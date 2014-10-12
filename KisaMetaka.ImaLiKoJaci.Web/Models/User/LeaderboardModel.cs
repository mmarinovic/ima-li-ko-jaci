namespace KisaMetaka.ImaLiKoJaci.Web.Models.User
{
    public class LeaderboardModel
    {
        public LeaderboardModel(string displayName, int score)
        {
            this.DisplayName = displayName;
            this.Score = score;
        }
        public string DisplayName { get; set; }
        public int Score { get; set; }
    }
}