using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevIo.AppMvc.Startup))]
namespace DevIo.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
