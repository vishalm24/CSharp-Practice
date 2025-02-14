using System.ComponentModel.DataAnnotations;

namespace WebAPI1.Model
{
    public class StudentEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Standard { get; set; }
        public string EmailAddress { get; set; }
    }
}
