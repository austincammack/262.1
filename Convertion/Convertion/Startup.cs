using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Convertion.Startup))]
namespace Convertion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
