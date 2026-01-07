using ByBiz.Models;
using Microsoft.EntityFrameworkCore;

namespace ByBiz.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PortfolioImages> PortfolioImages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
