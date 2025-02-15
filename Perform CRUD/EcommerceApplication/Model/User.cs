using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace EcommerceApplication.Model
{
//users:
//id guid pk
//first name string RE
//last name string RE
//phone number string RE
//email address string
//address string
//exist bool
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
