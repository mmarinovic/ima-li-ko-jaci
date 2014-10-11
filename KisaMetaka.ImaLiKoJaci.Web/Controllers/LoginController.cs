using System.Web.Mvc;
using Facebook;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Services;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly IUserRepository _userRepository;

        public LoginController(ILoginService loginService, IUserRepository userRepository)
        {
            _loginService = loginService;
            _userRepository = userRepository;
        }

        public ActionResult FacebookLogin()
        {
            var signedInUser = _loginService.TryGetSignedInUser();
            if (signedInUser != null) { return RedirectToRoute("Default"); }

            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = "1488571918075251",
                client_secret = "8137c8895a63f75cc861aeb138c63715",
                redirect_uri = Url.RouteUrl("FacebookCallback", new { }, Request.Url.Scheme),
                response_type = "code",
            });

            return Redirect(loginUrl.AbsoluteUri);
        }

        public ActionResult FacebookCallback(string code, string returnUrl)
        {
            var signedInUser = _loginService.TryGetSignedInUser();
            if (signedInUser != null) { return RedirectToRoute("Default"); }

            var fb = new FacebookClient();
            dynamic result = fb.Get("oauth/access_token", new
            {
                client_id = "1488571918075251",
                client_secret = "8137c8895a63f75cc861aeb138c63715",
                redirect_uri = Url.RouteUrl("FacebookCallback", new { }, Request.Url.Scheme),
                code = code
            });

            fb.AccessToken = result.access_token;
            dynamic me = fb.Get("me?fields=first_name,last_name,id");

            string facebookId = me.id;
            var user = _userRepository.TryGet(facebookId);

            if (user != null)
            {
                _loginService.SignIn(user.FacebookId);
            }
            else
            {
                string displayName = string.Format("{0} {1}", me.first_name, me.last_name);

                _userRepository.Create(facebookId, displayName);
            }

            return RedirectToRoute("Default");
        }
    }
}
