using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaasNet.Startup))]
namespace SaasNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
