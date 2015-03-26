using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZeMnaJedz.Startup))]
namespace ZeMnaJedz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
