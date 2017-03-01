using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialViewMVC.Startup))]
namespace PartialViewMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
