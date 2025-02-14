using System.ComponentModel.DataAnnotations;

namespace Web_API__Employee_Management_.Model
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string Description { get; set; }
    }
}
