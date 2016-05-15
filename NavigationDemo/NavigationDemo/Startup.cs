using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NavigationDemo.Startup))]
namespace NavigationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
