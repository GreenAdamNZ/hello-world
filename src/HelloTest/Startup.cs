using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloTest.Startup))]
namespace HelloTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
