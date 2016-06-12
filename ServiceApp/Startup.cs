using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceApp.Startup))]
namespace ServiceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
