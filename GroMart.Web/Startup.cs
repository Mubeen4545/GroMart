using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroMart.Web.Startup))]
namespace GroMart.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
