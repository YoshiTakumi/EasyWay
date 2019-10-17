using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyWay.Startup))]
namespace EasyWay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
