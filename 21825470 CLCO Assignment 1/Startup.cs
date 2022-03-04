using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_21825470_CLCO_Assignment_1.Startup))]
namespace _21825470_CLCO_Assignment_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
