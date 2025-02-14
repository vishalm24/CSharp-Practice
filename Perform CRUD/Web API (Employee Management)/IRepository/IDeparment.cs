using Web_API__Employee_Management_.Model;

namespace Web_API__Employee_Management_.IRepository
{
    public interface IDeparment
    {
        public IEnumerable<Department> GetDeparrtmentList();
    }
}
