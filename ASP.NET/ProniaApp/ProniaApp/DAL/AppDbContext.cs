using Microsoft.EntityFrameworkCore;
using ProniaApp.Models;
namespace ProniaApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SingleProduct> SingleProducts { get; set; }
    }
   
}
