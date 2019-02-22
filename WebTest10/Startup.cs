using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTest10.Startup))]
namespace WebTest10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
