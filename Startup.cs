using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bond_gadgets_entity_framework.Startup))]
namespace bond_gadgets_entity_framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
