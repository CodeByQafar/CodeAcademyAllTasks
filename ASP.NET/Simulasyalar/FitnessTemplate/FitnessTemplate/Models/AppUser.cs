using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FitnessTemplate.Models
{
    public class AppUser: IdentityUser
    {


        public string FullName { get; set; }





    }
}
