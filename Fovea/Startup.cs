using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fovea.Startup))]
namespace Fovea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
