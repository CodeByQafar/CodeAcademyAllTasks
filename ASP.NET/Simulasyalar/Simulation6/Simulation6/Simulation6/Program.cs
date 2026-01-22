

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Simulation6.DAL;
using Simulation6.Models;

namespace Exam
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

            builder.Services.AddIdentity<AppUser, IdentityRole>(
                opt =>
                {
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireUppercase = false;
                    opt.User.RequireUniqueEmail = true;


                }
                ).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "admin",
                pattern: "{area:exists}/{controller=home}/{action=index}/{id?}"

                );
            app.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=home}/{action=index}/{id?}"

                        );

            app.Run();


        }
    }
}