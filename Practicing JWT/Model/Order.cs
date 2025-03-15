using System.ComponentModel.DataAnnotations;

namespace Practicing_JWT.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
    }
}
