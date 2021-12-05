using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proveedores.Startup))]
namespace Proveedores
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
