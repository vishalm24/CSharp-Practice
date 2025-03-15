using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Practicing_JWT.Model
{
    public class Authentication
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public Guid? JTI { get; set; }
    }
}
