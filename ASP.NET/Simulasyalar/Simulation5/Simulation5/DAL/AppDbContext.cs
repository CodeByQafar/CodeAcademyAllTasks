using Microsoft.EntityFrameworkCore;
using Simulation5.Models;

namespace Simulation5.DAL
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) { }
        public DbSet<Chef> chefs { get; set; }
        public DbSet<Position> positions { get; set; }
    }
}
