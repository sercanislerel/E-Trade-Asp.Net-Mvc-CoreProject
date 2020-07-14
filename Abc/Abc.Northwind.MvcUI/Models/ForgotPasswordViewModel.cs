using System.ComponentModel.DataAnnotations;

namespace Abc.Northwind.MvcUI.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        

    }
}