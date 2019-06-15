using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArmorOn.Startup))]
namespace ArmorOn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
