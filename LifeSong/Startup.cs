using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeSong.Startup))]
namespace LifeSong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
