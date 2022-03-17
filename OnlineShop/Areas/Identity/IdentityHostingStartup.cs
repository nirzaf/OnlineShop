using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(OnlineShop.Areas.Identity.IdentityHostingStartup))]
namespace OnlineShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}