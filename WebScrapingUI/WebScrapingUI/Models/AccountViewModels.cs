using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebScrapingUI.Resources;

namespace WebScrapingUI.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Account))]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code", ResourceType = typeof(Account))]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Browser", ResourceType = typeof(Account))]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Account))]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Account))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Account))]
        public string Password { get; set; }

        [Display(Name = "Remember", ResourceType = typeof(Account))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Account))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Account), ErrorMessageResourceName = "Length", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Account))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm", ResourceType = typeof(Account))]
        [Compare("Password", ErrorMessageResourceType = typeof(Account), ErrorMessageResourceName = "PassMatch")]
        public string ConfirmPassword { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Account))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Account), ErrorMessageResourceName = "Length", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Account))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm", ResourceType = typeof(Account))]
        [Compare("Password", ErrorMessageResourceType = typeof(Account), ErrorMessageResourceName = "PassMatch")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Account))]
        public string Email { get; set; }
    }
}
