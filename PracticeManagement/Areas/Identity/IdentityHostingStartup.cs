//using System;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using PracticeManagement.Areas.Identity.Data;

//[assembly: HostingStartup(typeof(PracticeManagement.Areas.Identity.IdentityHostingStartup))]
//namespace PracticeManagement.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<ApplicationDbContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

//                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                    .AddEntityFrameworkStores<ApplicationDbContext>();
//            });
//        }
//    }
//}