using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly2.Startup))]
namespace Vidly2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
