using Microsoft.AspNetCore.Identity;

namespace Simulasya3.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
