using System.ComponentModel.DataAnnotations;

namespace Practicing_JWT.Model
{
    public class UserDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
