using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Ikbal.Startup))]
namespace Test_Ikbal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
