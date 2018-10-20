using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetPostgresEF.Startup))]
namespace ASPNetPostgresEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
