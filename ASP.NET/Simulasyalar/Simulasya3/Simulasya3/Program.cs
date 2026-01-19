
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Simulasya3.DAL;
using Simulasya3.Models;

namespace Simulasy3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });
            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 8;
                opt.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            var app = builder.Build();

         
            app.UseStaticFiles();
            app.UseRouting();
     app.UseAuthentication();
          app.UseAuthorization();
            app.MapControllerRoute(name: "admin", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
            app.MapControllerRoute(name: "defailt", pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();

        }
    }
}


