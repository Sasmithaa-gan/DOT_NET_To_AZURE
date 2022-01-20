using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(app1.Startup))]
namespace app1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
