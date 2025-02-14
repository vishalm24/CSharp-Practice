using Web_API__Employee_Management_.Data;
using Web_API__Employee_Management_.IRepository;
using Web_API__Employee_Management_.Model;

namespace Web_API__Employee_Management_.Repository
{
    public class DepartmentRepository : IDeparment
    {
        private readonly ApplicationDbContext _db;
        public DepartmentRepository(ApplicationDbContext context)
        {
            _db = context;
        }
        public IEnumerable<Department> GetDeparrtmentList()
        {
            IEnumerable<Department> department = _db.DepartmentReg.ToList();
            return department;
        }
    }
}
