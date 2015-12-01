using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INTEXApp.Startup))]
namespace INTEXApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
