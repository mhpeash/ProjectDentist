using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentistAppoinmentWebApp.Startup))]
namespace DentistAppoinmentWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
