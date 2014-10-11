using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Services
{
    public interface ILoginService
    {
        UserDto TryGetSignedInUser();

        void SignIn(string facebookId);
        void SignOut();
    }
}
