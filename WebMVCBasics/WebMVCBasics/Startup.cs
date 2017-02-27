using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVCBasics.Startup))]
namespace WebMVCBasics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
