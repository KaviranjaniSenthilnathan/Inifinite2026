using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges4.Question3
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee { EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", City="Mumbai"},
                new Employee { EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", City="Mumbai"},
                new Employee { EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", City="Pune"},
                new Employee { EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", City="Pune"},
                new Employee { EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", City="Mumbai"},
                new Employee { EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", City="Chennai"},
                new Employee { EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", City="Mumbai"},
                new Employee { EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", City="Chennai"},
                new Employee { EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", City="Chennai"},
                new Employee { EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", City="Pune"}
            };

            Console.WriteLine("ALL EMPLOYEES:");
            foreach (var e in empList)
                Console.WriteLine($"{e.EmployeeID} {e.FirstName} {e.City}");

            Console.WriteLine("\nNOT MUMBAI:");
            foreach (var e in empList.Where(x => x.City != "Mumbai"))
                Console.WriteLine($"{e.EmployeeID} {e.FirstName}");

            Console.WriteLine("\nASST MANAGER:");
            foreach (var e in empList.Where(x => x.Title == "AsstManager"))
                Console.WriteLine($"{e.EmployeeID} {e.FirstName}");

            Console.WriteLine("\nLAST NAME STARTS S:");
            foreach (var e in empList.Where(x => x.LastName.StartsWith("S")))
                Console.WriteLine($"{e.EmployeeID} {e.LastName}");
        }
    }
}