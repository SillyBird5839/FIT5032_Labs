using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab20240627.Startup))]
namespace lab20240627
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
