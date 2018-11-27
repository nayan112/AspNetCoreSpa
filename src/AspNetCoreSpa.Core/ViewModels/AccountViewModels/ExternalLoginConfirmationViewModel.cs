using System.ComponentModel.DataAnnotations;

namespace MyCommunity.Core.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
