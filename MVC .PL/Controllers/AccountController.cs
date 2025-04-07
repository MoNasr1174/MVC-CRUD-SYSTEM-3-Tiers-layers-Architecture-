using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.DAL.Models;
using MVC_.PL.Helpers;
using MVC_.PL.ViewModels;
using System;
using System.Threading.Tasks;

namespace MVC_.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager , SignInManager<ApplicationUser> signInManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #region sign Up
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByNameAsync(Model.UserName);

                if (User is null)
                {
                    User = new ApplicationUser()
                    {
                        UserName = Model.UserName,
                        Email = Model.Email,
                        FName = Model.FName,
                        LName = Model.LName,
                        IsAgree = Model.IsAgree

                    };

                    var result = await _userManager.CreateAsync(User, Model.Password);
                    if (result.Succeeded)
                    {

                        return RedirectToAction(nameof(SignIn));
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                ModelState.AddModelError("", "USERNAME OR EMAIL ALREADY EXISTS");

            }

            // If the model state is not valid, return the view with validation errors
            return View(Model);
        }
        #endregion

        #region SignIn and Sign out
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> SignIn(SignInViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(Model.Email);
                if (User is not null)
                {
                    var flag = await _userManager.CheckPasswordAsync(User, Model.Password);
                    if (flag)
                    {

                        // var result = await _signInManager.PasswordSignInAsync(User, Model.Password, Model.RememberMe, false);
                        await _signInManager.SignInAsync(User, Model.RememberMe);

                        if (HttpContext.User.Identity?.IsAuthenticated == true)
                        {
                            Console.WriteLine("User is authenticated!");
                        }
                        else
                        {
                            Console.WriteLine("Authentication failed!");
                        }

                        return RedirectToAction("Index", "Home");

                    }
                }
                ModelState.AddModelError("", "Invalid Login Attempt");
            }
            return View(Model);
        }


        public async new Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }

        #endregion

        #region ForgetPassword
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> SendEmail(ForgetPaswwordViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(Model.Email);
                if (User is not null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(User); // unique token for User one-time
                    var passwordUrL = Url.Action("ResetPassword", "Account", new { email = Model.Email, token = token }, Request.Scheme);
                    var email = new Email()
                    {
                        RecipientsS = Model.Email,
                        Subject = "Reset Your Password",
                        Body = $"Please reset your password by clicking here: <a href='{passwordUrL}'>link</a>"
                    };
                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckYourInbox));
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");

            }
            return View(Model);
        }


        public IActionResult CheckYourInbox()
        {
            return View();
        } 
        #endregion

        #region Reset Password 

        public IActionResult ResetPassword(string email, string token)
        {
            TempData["Email"] = email;
            TempData["Token"] = token;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel Model)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(TempData["Email"].ToString());
                if (User is not null)
                {
                    var result = await _userManager.ResetPasswordAsync(User, TempData["Token"].ToString(), Model.NewPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(SignIn));
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                ModelState.AddModelError("", "Invalid Email");
            }
            return View(Model);
        }
        #endregion

    }

}
