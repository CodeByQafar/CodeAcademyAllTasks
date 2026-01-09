using System.ComponentModel.DataAnnotations;

namespace AdminPanel.ViewModels.Auth
{
    public class LoginVM
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "invaild email type")]
        public string Email { get; set; }
        [DataType(DataType.Password, ErrorMessage = "invaild password type")]
        public string Password { get; set; }
    }
}
