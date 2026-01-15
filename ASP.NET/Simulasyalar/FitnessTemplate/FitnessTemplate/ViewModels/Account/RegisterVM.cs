using System.ComponentModel.DataAnnotations;

namespace FitnessTemplate.ViewModels.Account
{
    public class RegisterVM
    {
        [MaxLength(30, ErrorMessage = "FullName length can't be Longer than 30 chat=racter")]
        [MinLength(3, ErrorMessage = "FullName length can't be shorter than 3 chat=racter")]
        public string FullName { get; set; }
        [MaxLength(30, ErrorMessage = "UserName length can't be Longer than 30 chat=racter")]
        [MinLength(3, ErrorMessage = "UserName length can't be shorter than 3 chat=racter")]
        public string UserName { get; set; }
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Compare(nameof(Password),ErrorMessage ="comfrim password is inccorect")]
        public string ConfirmPassword { get; set; }
    }
}
