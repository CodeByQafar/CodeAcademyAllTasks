using Microsoft.AspNetCore.Identity;

namespace ticket4.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }    
    }
}
