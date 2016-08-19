using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_RemoteValidateModel.Startup))]
namespace Demo_RemoteValidateModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
