using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HR_Olympics.Startup))]
namespace HR_Olympics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
