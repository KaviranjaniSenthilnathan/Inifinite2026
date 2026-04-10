using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }

    class Program3
    {
        static void Main()
        {
            // Populate employee data
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Arun", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Divya", EmpCity = "Chennai", EmpSalary = 42000 },
            new Employee { EmpId = 3, EmpName = "Kiran", EmpCity = "Bangalore", EmpSalary = 60000 },
            new Employee { EmpId = 4, EmpName = "Meena", EmpCity = "Hyderabad", EmpSalary = 48000 },
            new Employee { EmpId = 5, EmpName = "Ravi", EmpCity = "Mumbai", EmpSalary = 38000 }
        };

            // a. Display all employees
            Console.WriteLine("a. All Employees:");
            DisplayEmployees(employees);

            // b. Employees with salary > 45000
            Console.WriteLine("\nb. Employees with Salary > 45000:");
            var highSalary = employees.Where(e => e.EmpSalary > 45000);
            DisplayEmployees(highSalary);

            // c. Employees from Bangalore
            Console.WriteLine("\nc. Employees from Bangalore Region:");
            var bangaloreEmployees = employees
                .Where(e => e.EmpCity.Equals("Bangalore", StringComparison.OrdinalIgnoreCase));
            DisplayEmployees(bangaloreEmployees);

            // d. Employees sorted by name (Ascending)
            Console.WriteLine("\nd. Employees Sorted by Name (Ascending):");
            var sortedByName = employees.OrderBy(e => e.EmpName);
            DisplayEmployees(sortedByName);
        }

        // Utility method to display employee data
        static void DisplayEmployees(IEnumerable<Employee> empList)
        {
            foreach (var emp in empList)
            {
                Console.WriteLine(
                    $"Id: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}"
                );
            }
        }
    }
}