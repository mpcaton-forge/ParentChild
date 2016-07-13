using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParentChild.WebUI.Startup))]
namespace ParentChild.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
