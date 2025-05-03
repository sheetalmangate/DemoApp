using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class RegistrationViewModel
    {

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Email required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")]
       
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required.")]
        [MaxLength(16, ErrorMessage = "Max 16 character allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Please confirm your password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set;}

    }
}
