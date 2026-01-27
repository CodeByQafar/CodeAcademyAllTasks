using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDBContext:IdentityDbContext<AppUser>
    {

        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }

    }
}
