using System.ComponentModel.DataAnnotations;

namespace MyCommunity.STS.Models
{
    public class DeletePersonalDataViewModel
    {
        public bool RequirePassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "PASSWORD_REQUIRED")]
        public string Password { get; set; }
    }
}
