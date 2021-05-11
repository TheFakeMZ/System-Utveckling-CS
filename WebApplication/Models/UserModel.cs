using System;
// using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Web; 

namespace WebApplication.Models
{
    public class UserViewModel
    {
        [Display(Name = "User name")]
        
        [Required(ErrorMessage = "Enter a user name!")]
        public string Username { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter a first name!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter a last name!")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter a valid Email!")] 
        public string Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("Email", ErrorMessage = "The Emails do not match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password entered is too short.")]
        [Required(ErrorMessage = "Enter a password!")]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
