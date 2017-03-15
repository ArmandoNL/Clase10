using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(n_Capas.Startup))]
namespace n_Capas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
