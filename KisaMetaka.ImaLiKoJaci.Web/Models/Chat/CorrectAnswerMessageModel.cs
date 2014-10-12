using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Web.Models.Chat
{
    public class CorrectAnswerMessageModel: MessageModel
    {
        public CorrectAnswerMessageModel(UserDto user, string text, MessageType type, string songUrl, int fromSecond, int toSecond) : base(user, text, type)
        {
            this.SongUrl = songUrl;
            this.FromSecond = fromSecond;
            this.ToSecond = toSecond;
        }

        public string SongUrl { get; set; }
        public int FromSecond { get; set; }
        public int ToSecond { get; set; }
    }
}