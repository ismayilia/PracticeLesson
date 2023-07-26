using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Controllers
{
    internal class EmployeeController
    {
        private EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAllEmployees()
        {
            var employees = _employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result = $"{employee.Id}, {employee.Name}, {employee.Age}, {employee.Salary}";
                Console.WriteLine(result);
            }

        }



        public void GetEmployeeById()
        {
            int id = 2;
            var employee = _employeeService.GetById(id);
            Console.WriteLine(employee.Id + "," + employee.Name);
        }
    }
}
