using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KisaMetaka.ImaLiKoJaci.Web.SignalRConfig))]
namespace KisaMetaka.ImaLiKoJaci.Web
{
    public class SignalRConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}