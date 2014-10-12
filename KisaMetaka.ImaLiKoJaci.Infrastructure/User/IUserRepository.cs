using System.Collections.Generic;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.User
{
    public interface IUserRepository
    {
        void Create(string displayName, string facebookId);
        void Update(int id, string displayName);
        UserDto TryGet(string facebookId);
        IEnumerable<UserDto> GetForLeaderboard();
    }
}
