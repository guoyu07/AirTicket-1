using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirTicket.Startup))]
namespace AirTicket
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
