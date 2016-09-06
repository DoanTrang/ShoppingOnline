using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingOnline.Startup))]
namespace ShoppingOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
