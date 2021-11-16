using System;
using Login_Registration_Page.Areas.Identity.Data;
using Login_Registration_Page.Data;
using Login_Registration_Page.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Login_Registration_Page.Areas.Identity.IdentityHostingStartup))]
namespace Login_Registration_Page.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                services.AddDbContext<SampleAppContext>(options =>
                options.UseSqlServer(
                    context.Configuration.GetConnectionString("SampleAppContextConnection")));

                services.AddIdentity<SampleAppUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddDefaultUI()
                    .AddEntityFrameworkStores<SampleAppContext>()
                    .AddDefaultTokenProviders();

                services.AddScoped<IUserClaimsPrincipalFactory<SampleAppUser>,
                    ApplicationUserClaimsPrincipalFactory
                    >();

            });
        }
    }
}