using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EndUserSite.Startup))]
namespace EndUserSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
