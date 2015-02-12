using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPrac.Startup))]
namespace WebAppPrac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
