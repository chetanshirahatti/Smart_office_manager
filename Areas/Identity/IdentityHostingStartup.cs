using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SmartOfficeManager.Areas.Identity.IdentityHostingStartup))]
namespace SmartOfficeManager.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            // No configuration needed here,
            // Identity UI just needs this file to activate.
        }
    }
}
