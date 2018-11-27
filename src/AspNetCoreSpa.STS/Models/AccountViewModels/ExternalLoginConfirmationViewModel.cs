using System.ComponentModel.DataAnnotations;

namespace MyCommunity.STS.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "EMAIL_REQUIRED")]
        [EmailAddress(ErrorMessage = "EMAIL_INVALID")]
        public string Email { get; set; }
    }
}
