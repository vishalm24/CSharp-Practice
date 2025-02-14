using Microsoft.EntityFrameworkCore;
using Web_API__Employee_Management_.Model;

namespace Web_API__Employee_Management_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> EmployeeReg { get; set; }
        public DbSet<Department> DepartmentReg { get; set; }
    }
}
