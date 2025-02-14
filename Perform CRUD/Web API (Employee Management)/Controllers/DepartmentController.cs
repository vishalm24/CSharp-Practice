using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API__Employee_Management_.Data;
using Web_API__Employee_Management_.IRepository;
using Web_API__Employee_Management_.Model;
using Web_API__Employee_Management_.Repository;

namespace Web_API__Employee_Management_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDeparment _Department;
        public DepartmentController(IDeparment department)
        {
            _Department = department;
        }
        [HttpGet]
        public IActionResult GetDepartmentList()
        {
            IEnumerable<Department> department = _Department.GetDeparrtmentList();
            if(department == null)
            {
                return NotFound();
            }
            else
            {
                return department;
            }
        }
    }
}
