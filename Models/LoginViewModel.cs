using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password required.")]
        [MaxLength(16, ErrorMessage = "Max 16 character allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
