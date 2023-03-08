using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuachTuanKhang_2011064401_Lab03.Startup))]
namespace QuachTuanKhang_2011064401_Lab03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
