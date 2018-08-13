using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Slaes.Backend.Startup))]
namespace Slaes.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
