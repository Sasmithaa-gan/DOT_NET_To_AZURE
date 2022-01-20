using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trial.Startup))]
namespace trial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
