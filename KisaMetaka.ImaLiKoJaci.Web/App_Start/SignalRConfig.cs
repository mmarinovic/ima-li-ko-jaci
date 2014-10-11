using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KisaMetaka.ImaLiKoJaci.Web.SignalRConfig))]
namespace KisaMetaka.ImaLiKoJaci.Web
{
    public class SignalRConfig
    {
        public void Configuration(IAppBuilder app)
        {
            var hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;
            app.MapSignalR(hubConfiguration);
        }
    }
}