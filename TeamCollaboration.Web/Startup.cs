using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCollaboration.Web.Startup))]
namespace TeamCollaboration.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
