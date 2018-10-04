using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrograWeb.Lunes.Calculadora.Startup))]
namespace PrograWeb.Lunes.Calculadora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
