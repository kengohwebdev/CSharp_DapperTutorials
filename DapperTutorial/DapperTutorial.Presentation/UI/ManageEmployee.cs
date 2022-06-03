using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Presentation.UI
{
    public class ManageEmployee
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        private void AddEmployee()
        {
            Employee e = new Employee();
            Console.Write("Enter First Name: ");
            e.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            e.LastName = Console.ReadLine();
            Console.Write("Enter Salary ==>");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Department Id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());

            employeeRepository.Insert(e);

        }
        private void GetAllEmployees()
        {
            IEnumerable<Employee> employees = employeeRepository.GetAll();
            foreach(var item in employees)
            {
                Console.WriteLine($"{item.FirstName} \t {item.Salary} \t {item.Dept.DName}");
            }
        }

        public void Run()
        {

            //Do While loop here that uses Enums and Switches to continously ask for operation till exit
            AddEmployee();
            GetAllEmployees();
        }
    }
}
