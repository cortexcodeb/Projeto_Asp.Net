using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestauranteProjetoWeb.Startup))]
namespace RestauranteProjetoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
