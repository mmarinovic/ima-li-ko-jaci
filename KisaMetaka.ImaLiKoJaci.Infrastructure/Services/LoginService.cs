using System;
using System.Web;
using System.Web.Security;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;

        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto TryGetSignedInUser()
        {
            var facebookId = HttpContext.Current.User.Identity.Name;
            if (string.IsNullOrWhiteSpace(facebookId)) { return null; }

            var user = _userRepository.TryGet(facebookId);
            if (user == null) { return null; }

            return user;
        }

        public void SignIn(string facebookId)
        {
            if (string.IsNullOrWhiteSpace(facebookId)) { throw new ArgumentException("facebookId"); }

            FormsAuthentication.SetAuthCookie(facebookId, true);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
