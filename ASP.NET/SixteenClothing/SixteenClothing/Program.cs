

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBContext>(opt =>
            {

                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));

            });

            builder.Services.AddIdentity<AppUser, IdentityRole>(
                opt =>
                {
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireUppercase = false;

                }
            ).AddEntityFrameworkStores<AppDBContext>().AddDefaultTokenProviders();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}"
         );

            app.Run();



        }
    }
}