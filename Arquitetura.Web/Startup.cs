using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arquitetura.Web.Startup))]
namespace Arquitetura.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
