using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace AdminPanel.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Purchace> Purchaces { get; set; }

    }
}
