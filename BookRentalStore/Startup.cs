using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookRentalStore.Startup))]
namespace BookRentalStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
