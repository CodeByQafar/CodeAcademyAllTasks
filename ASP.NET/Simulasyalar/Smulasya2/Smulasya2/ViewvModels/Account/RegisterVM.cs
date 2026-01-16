using System.ComponentModel.DataAnnotations;

namespace Smulasya2.ViewvModels.Account
{
    public class RegisterVM
    {
        [MaxLength(30, ErrorMessage = "FullName cant't be longer than 30 chracters ")]
        [MinLength(3, ErrorMessage = "FullName cant't be shorter than 3 chracters ")]
        public string FullName { get; set; }
        [MaxLength(30, ErrorMessage = "user name cant't be longer than 30 chracters ")]
        [MinLength(3, ErrorMessage = "user name cant't be shorter than 3 chracters ")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "Passswords not matching")]
        public string ConfrimPassword { get; set; }
    }
}
