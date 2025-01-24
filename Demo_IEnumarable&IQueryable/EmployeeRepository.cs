using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IEnumarable_IQueryable
{
    internal class EmployeeRepository
    {
        public List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee(){ EmpName = "Vishal", DeptName = "Dot Net", Address = "Dombivli", Salary = 15000.00M},

            };
        }
    }
}
