using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Areas.Admin.DAL
{
    public class AdminDbContext:DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
           
        }
        public DbSet<Purchace> purchaces { get; set; }
    }
}
