using System.ComponentModel.DataAnnotations;

namespace EcommerceApplication.Model
{
//categories:
//id int pk
//name string RE
//exist bool
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
