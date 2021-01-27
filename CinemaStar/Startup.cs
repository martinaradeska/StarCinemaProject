using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinemaStar.Startup))]
namespace CinemaStar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
