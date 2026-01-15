using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Smulasya2.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
