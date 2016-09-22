using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agitator.WebSite.Startup))]
namespace Agitator.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
