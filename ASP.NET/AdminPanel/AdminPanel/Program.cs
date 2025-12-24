
using AdminPanel.DAL;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt => {
                opt.UseSqlServer(
                "Server=DESKTOP-FJ28S1F\\LOCALDB#CDF01C35;" +
                "Database=ProniaAppAdminDb;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True"
            );

            });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
               name: "admin",
               pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
               );

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }

    }
}



