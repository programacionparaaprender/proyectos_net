using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaWebMVC.Startup))]
namespace PruebaWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
