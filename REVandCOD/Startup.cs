using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REVandCOD.Startup))]
namespace REVandCOD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
