using System;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.User
{
    public class UserDto
    {
        public UserDto(Data.User user)
        {
            if (user == null) { throw new ArgumentException("user"); }

            this.Id = user.Id;
            this.DisplayName = user.DisplayName;
            this.FacebookId = user.FacebookId;
            this.JoinedOn = user.JoinedOn;
            this.TotalScore = user.TotalScore;
        }

        public int Id { get; private set; }
        public string DisplayName { get; private set; }
        public string FacebookId { get; private set; }
        public DateTime JoinedOn { get; private set; }
        public int TotalScore { get; private set; }
    }
}
