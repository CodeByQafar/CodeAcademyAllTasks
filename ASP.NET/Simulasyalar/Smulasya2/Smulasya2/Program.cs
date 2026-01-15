using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smulasya2.DAL;
using Smulasya2.Models;

namespace ticket
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(
                opt =>

                    opt.UseSqlServer(builder.Configuration.GetConnectionString("default"))
             
                );
            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            var app = builder.Build();
     
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");
            app.MapControllerRoute(name: "admin", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
            app.Run();

        }
    }
}

