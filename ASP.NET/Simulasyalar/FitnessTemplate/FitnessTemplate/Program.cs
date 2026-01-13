using FitnessTemplate.DAL;
using Microsoft.EntityFrameworkCore;

namespace FitnessTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt => {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
                }

             );         
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            app.MapControllerRoute(
            name: "addmin",
            pattern: "{area=admin}/{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();

        }
    }
}