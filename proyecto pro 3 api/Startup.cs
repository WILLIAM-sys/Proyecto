using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto_pro_3_api.Startup))]
namespace proyecto_pro_3_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
