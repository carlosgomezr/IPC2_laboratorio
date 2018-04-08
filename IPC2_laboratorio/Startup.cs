using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IPC2_laboratorio.Startup))]
namespace IPC2_laboratorio
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
