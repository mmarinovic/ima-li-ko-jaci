using System.Collections.Generic;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.User
{
    public interface IUserRepository
    {
        void Create(string displayName, string facebookId);
        void Update(int id, string displayName);
        void AddScore(int id, int scoreValue);

        UserDto TryGet(string facebookId);
        UserDto GetAnonymous();
        UserDto GetBot();
        IEnumerable<UserDto> GetForLeaderboard();
    }
}
