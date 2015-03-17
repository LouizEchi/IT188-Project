using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Powerlink.Startup))]
namespace Powerlink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
