using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICT_Project.Startup))]
namespace ICT_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
