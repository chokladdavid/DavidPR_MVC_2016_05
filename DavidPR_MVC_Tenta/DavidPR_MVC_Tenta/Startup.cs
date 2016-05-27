using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavidPR_MVC_Tenta.Startup))]
namespace DavidPR_MVC_Tenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
