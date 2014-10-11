using System;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Web.Models.Chat
{
    public class AnswerModel
    {
        public AnswerModel(UserDto user, string answer)
        {
            if (user == null) { throw new ArgumentException("user"); }
            if (string.IsNullOrWhiteSpace(answer)) { throw new ArgumentException("answer"); }

            this.Timestamp = DateTime.Now;
            this.User = user;
            this.Answer = answer;
        }

        public DateTime Timestamp { get; private set; }
        public UserDto User { get; private set; }
        public string Answer { get; private set; }
    }
}