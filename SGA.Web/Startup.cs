using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGA.Web.Startup))]
namespace SGA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
