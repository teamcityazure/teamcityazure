using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamcityazureApp.Startup))]
namespace teamcityazureApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
