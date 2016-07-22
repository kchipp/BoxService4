using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoxService4.Startup))]
namespace BoxService4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
