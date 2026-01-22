using System.ComponentModel.DataAnnotations;

namespace Simulation6.ViewModels.Account
{
    public class RegisterVM
    {
        [MaxLength(30, ErrorMessage = "Full name can't be longer than 30 characters")]
        [MinLength(3, ErrorMessage = "Full name can't be longer than 3 characters")]
        public string FullName { get; set; }

        [MaxLength(30, ErrorMessage = "User Name can't be longer than 30 characters")]
        [MinLength(3, ErrorMessage = "User Name can't be longer than 3 characters")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "email is invaild")]
        public string Email { get; set; }

        [DataType(DataType.Password, ErrorMessage = "pasword is invaild")]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "password not matching")]
        public string ConfrimPassword { get; set; }
    }
}
