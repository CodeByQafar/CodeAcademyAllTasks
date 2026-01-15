using System.ComponentModel.DataAnnotations;

namespace FitnessTemplate.ViewModels.Account
{
    public class LoginVM
    {
       
        [MaxLength(30, ErrorMessage = "Field length can't be Longer than 30 chat=racter")]
        [MinLength(3, ErrorMessage = "Field length can't be shorter than 3 chat=racter")]
        public string EmailOrUserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
