using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_.PL.ViewModels
{
    public class SignUpViewModel

    {
        [Required(ErrorMessage = "First Name Is Required")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Last Name Is Required")]
        public string LName { get; set; }

        [Required(ErrorMessage = "UserName Is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " Email Address Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Passowrd Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmed Passowrd Is Required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Not Matched")]
        public string ConfirmedPassword { get; set; }
        public bool IsAgree { get; set; }
    }
}
