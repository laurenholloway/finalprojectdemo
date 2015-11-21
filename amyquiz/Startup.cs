using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amyquiz.Startup))]
namespace amyquiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
