using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASS2._5final.Startup))]
namespace ASS2._5final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
