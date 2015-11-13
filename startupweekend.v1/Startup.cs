using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(startupweekend.v1.Startup))]
namespace startupweekend.v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
