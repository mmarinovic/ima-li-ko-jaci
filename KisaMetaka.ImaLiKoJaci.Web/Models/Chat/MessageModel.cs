using System;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Web.Models.Chat
{
    public class MessageModel
    {
        public MessageModel(UserDto user, string text, MessageType type)
        {
            if (user == null) { throw new ArgumentException("user"); }
            if (string.IsNullOrWhiteSpace(text)) { throw new ArgumentException("text"); }

            this.Timestamp = DateTime.Now;
            this.User = user;
            this.Text = text;
            this.Type = type;
        }

        public DateTime Timestamp { get; private set; }
        public UserDto User { get; private set; }
        public string Text { get; private set; }
        public MessageType Type { get; set; }
    }
}