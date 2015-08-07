using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityWithAutofac.Web.Startup))]
namespace IdentityWithAutofac.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
