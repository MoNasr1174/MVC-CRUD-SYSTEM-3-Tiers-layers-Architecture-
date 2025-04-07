using System.ComponentModel.DataAnnotations;

namespace MVC_.PL.ViewModels
{
    public class ForgetPaswwordViewModel
    {
        [Required(ErrorMessage = " Email Address Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}
