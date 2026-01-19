using System.ComponentModel.DataAnnotations;

namespace Smulasya2.ViewvModels.Account
{
    public class LoginVM
    {
      
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
   public bool RememberMe { get; set; }
    }
}
