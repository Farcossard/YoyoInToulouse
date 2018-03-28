using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yoyo.Startup))]
namespace Yoyo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
