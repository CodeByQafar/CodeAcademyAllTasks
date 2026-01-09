using System.ComponentModel.DataAnnotations;

namespace AdminPanel.ViewModels.Auth
{
    public class RegisterVM
    {
        [MaxLength(30,ErrorMessage = "First Name length cant't be longer than 30 character")]
        [MinLength(3,ErrorMessage = "First Name length cant't be shorter than 3 character")]
        public string FirstName { get; set; }
        [MaxLength(30, ErrorMessage = "Last Namee length cant't be longer than 30 character")]
        [MinLength(3, ErrorMessage = "Last Name length cant't be shorter than 3 character")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="invaild email type")]
        public string Email { get; set; }
        [DataType(DataType.Password, ErrorMessage = "invaild password type")]
        public string Password { get; set; }    
        [Compare(nameof(Password),ErrorMessage ="confrim password is not correct")]
        public string ConfrimPassword { get; set; }

    }
}
