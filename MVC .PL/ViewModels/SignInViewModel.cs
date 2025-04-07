using System.ComponentModel.DataAnnotations;

namespace MVC_.PL.ViewModels
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = " Email Address Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Passowrd Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

    }
}
