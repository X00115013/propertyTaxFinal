using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(propertyTaxFinal.Startup))]
namespace propertyTaxFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
