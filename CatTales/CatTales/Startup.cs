using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatTales.Startup))]
namespace CatTales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
