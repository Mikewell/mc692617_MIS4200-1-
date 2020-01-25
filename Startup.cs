using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mc692617_MIS4200.Startup))]
namespace mc692617_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
