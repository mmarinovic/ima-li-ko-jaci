using System.Web.Mvc;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Services;
using Newtonsoft.Json.Linq;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class ShellController : Controller
    {
        private readonly ILoginService _loginService;
        public ShellController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public ActionResult Shell()
        {
            var currentUser = _loginService.TryGetSignedInUser();
            return View(
                currentUser == null 
                ? new JObject()
                : JObject.FromObject(currentUser)
          );
        }
    }
}
