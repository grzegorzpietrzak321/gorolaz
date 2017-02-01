using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gorolaz.Startup))]
namespace Gorolaz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
