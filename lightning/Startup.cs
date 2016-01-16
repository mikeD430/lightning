using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lightning.Startup))]
namespace lightning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
