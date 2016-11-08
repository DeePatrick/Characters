using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Characters.Startup))]
namespace Characters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
