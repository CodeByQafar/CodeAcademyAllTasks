using Microsoft.AspNetCore.Identity;

namespace Simulation6.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
