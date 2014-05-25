using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParentGuardWebApp.Startup))]
namespace ParentGuardWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
