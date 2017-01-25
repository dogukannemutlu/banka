using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogukanNemutlu.Startup))]
namespace DogukanNemutlu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
