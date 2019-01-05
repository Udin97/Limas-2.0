using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Limas_2._0.Startup))]
namespace Limas_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
