using System.ComponentModel.DataAnnotations;

namespace Simulation5.ViewModels.Account
{
    public class RegisterVM
    {

        [MaxLength(30,ErrorMessage ="FullName cant be longer than 30")]
        [MinLength(3,ErrorMessage ="FullName cant be shorter 3 character")]
        public string FullName { get; set; }
        [MaxLength(30, ErrorMessage = "UserName cant be longer than 30")]
        [MinLength(3, ErrorMessage = "UserName cant be shorter 3 character")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }
      

        public string ConfrimPassword { get; set; }
    }
}
