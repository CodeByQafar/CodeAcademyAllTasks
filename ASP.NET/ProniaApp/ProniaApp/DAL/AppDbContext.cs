using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

namespace ProniaApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
    }
=======
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
   
>>>>>>> e0010f2c2514cb938bbcbaabf4c64aea975c0d84
}
