using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels.Account
{
    public class RegisterVM
    {

        [MaxLength(30,ErrorMessage ="Full name cant be longer than 30 characters")]
        [MinLength(3,ErrorMessage = "Full name cant be shorter than 3 characters")]
        public string FullName { get; set; }

        [MaxLength(30, ErrorMessage = "UserName cant be longer than 30 characters")]
        [MinLength(3, ErrorMessage = "UserName cant be shorter than 3 characters")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string ConfrimPassword { get; set; }
    }
}
