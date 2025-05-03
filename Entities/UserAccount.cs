using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required." )]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")] 
        public String FirstName { get; set; }
        
        [Required(ErrorMessage = "Last name is required." )]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Email required." )]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required.")]
        [MaxLength(16, ErrorMessage = "Max 16 character allowed.")]
        public string Password { get; set; }
    }
}
