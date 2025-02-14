using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API__Employee_Management_.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Department department { get; set; }
        [ForeignKey("Department")]
        public int departmentId { get; set; }
    }
}
