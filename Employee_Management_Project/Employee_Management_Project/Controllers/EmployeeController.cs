using Employee_Management_Project.Models;
using Employee_Management_Project;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Onkar",
                Department = "IT",
                Email = "onkar@example.com",
                Salary = 30000
            }
        };

        // GET: Display all employees
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(employees);
        }

        // GET: Display employee by ID
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            Employee? employee =
                employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        // POST: Add a new employee
        [HttpPost]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            if (employees.Any(e => e.Id == employee.Id))
                return Conflict("Employee ID already exists.");

            employees.Add(employee);

            return CreatedAtAction(
                nameof(GetEmployee),
                new { id = employee.Id },
                employee);
        }

        // PUT: Update employee
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(
            int id, Employee updatedEmployee)
        {
            Employee? employee =
                employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            employee.Email = updatedEmployee.Email;
            employee.Salary = updatedEmployee.Salary;

            return NoContent();
        }

        // DELETE: Delete employee
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            Employee? employee =
                employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            employees.Remove(employee);

            return NoContent();
        }
    }
}