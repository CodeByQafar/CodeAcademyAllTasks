using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simulasya3.Models;

namespace Simulasya3.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
      public  DbSet<Team> Teams { get; set; }
    }
}
