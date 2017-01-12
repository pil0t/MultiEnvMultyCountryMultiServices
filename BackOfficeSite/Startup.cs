using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BackOfficeSite.Startup))]
namespace BackOfficeSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
