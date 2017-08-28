using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Procedures.Startup))]
namespace Procedures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
