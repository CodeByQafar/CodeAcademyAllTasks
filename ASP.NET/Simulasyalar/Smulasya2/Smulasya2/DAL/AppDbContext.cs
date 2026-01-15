using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smulasya2.Models;

namespace Smulasya2.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
      public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

      public  DbSet<Member> Members { get; set; }
    }
}
