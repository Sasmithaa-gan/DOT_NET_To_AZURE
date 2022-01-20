using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azure_demo.Startup))]
namespace azure_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
