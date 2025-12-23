<<<<<<< HEAD


namespace ProniaApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(
              name:"default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            app.Run();
        }
    }
}
=======
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProniaApp.DAL;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(ops =>
ops.UseSqlServer(
    "Server=localhost\\SQLEXPRESS01;Database=ProniaDb;Trusted_Connection=True;TrustServerCertificate=True"
    )
);
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
>>>>>>> e0010f2c2514cb938bbcbaabf4c64aea975c0d84
