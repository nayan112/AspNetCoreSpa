using System.ComponentModel.DataAnnotations;

namespace MyCommunity.Core.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
