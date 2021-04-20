using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerce_App.Startup))]
namespace eCommerce_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
