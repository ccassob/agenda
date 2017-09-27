using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agenda.Web.Startup))]
namespace Agenda.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
