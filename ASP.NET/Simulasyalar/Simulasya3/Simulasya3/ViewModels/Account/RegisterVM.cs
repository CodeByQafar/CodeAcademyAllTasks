using System.ComponentModel.DataAnnotations;

namespace Simulasya3.ViewModels.Account
{
    public class RegisterVM
    {
        [MaxLength(30, ErrorMessage = "FullName is cant be longer than 30 characters")]
        [MinLength(3, ErrorMessage = "FullName is cant be shoter than 3 characters")]
        public string FullName { get; set; }

        [MaxLength(30, ErrorMessage = "username is cant be longer than 30 characters")]
        [MinLength(3, ErrorMessage = "username is cant be shoter than 3 characters")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "password is not matching")]
        public string ConfrimPassword { get; set; }

        public bool RememberMe { get; set; }

    }
}
