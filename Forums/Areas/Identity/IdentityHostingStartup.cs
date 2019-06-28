using Forums.Data;
using Forums.Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Forums.Areas.Identity.IdentityHostingStartup))]
namespace Forums.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ForumsDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ForumsContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>()
                    .AddEntityFrameworkStores<ForumsDbContext>();
            });
        }
    }
}