using System.ComponentModel.DataAnnotations;

namespace Simulasya3.ViewModels.Account
{
    public class LoginVM
    {

        public string UserNameOrEmail { get; set; }
  
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
