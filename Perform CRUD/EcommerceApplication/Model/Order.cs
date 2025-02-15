using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApplication.Model
{
//orders:
//id guid pk
//customerid guid fk RE
//productid int fk RE
//price float
//exist bool
    public class Order
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public User User { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public float Price { get; set; }
        public bool IsActive { get; set; }
    }
}
