using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moviemall.Startup))]
namespace moviemall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
