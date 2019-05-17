using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolSystem3.Startup))]
namespace SchoolSystem3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
