using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnTopOfIt.Areas.Identity.Data;
using OnTopOfIt.Data;

[assembly: HostingStartup(typeof(OnTopOfIt.Areas.Identity.IdentityHostingStartup))]
namespace OnTopOfIt.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginDbContextConnection")));

              //  services.AddDefaultIdentity<OnTopOfItUser>(options => options.SignIn.RequireConfirmedAccount = true)
               //  .AddEntityFrameworkStores<LoginDbContext>();
            });
        }
    }
}