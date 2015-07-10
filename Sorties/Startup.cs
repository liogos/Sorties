using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sorties.Startup))]
namespace Sorties
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
