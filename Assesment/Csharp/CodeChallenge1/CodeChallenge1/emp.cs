using System;
using System.Collections.Generic;
class Emp
{
    public int id { get; set; }
    public string name { get; set; }
    public string dept { get; set; }
    public double sal { get; set; }
}
class EmpProgram
{
    private List<Emp> list = new List<Emp>();

    public void Run()
    {
        int ch = 0;

        while (ch != 6)
        {
            Console.WriteLine("\n1 Add  2 View  3 Search  4 Update  5 Delete  6 Exit");
            Console.Write("Enter your choice: ");
            ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Emp e = new Emp();
                Console.Write("Id: "); e.id = int.Parse(Console.ReadLine());
                Console.Write("Name: "); e.name = Console.ReadLine();
                Console.Write("Dept: "); e.dept = Console.ReadLine();
                Console.Write("Salary: "); e.sal = double.Parse(Console.ReadLine());
                list.Add(e);
                Console.WriteLine("Employee added!");
            }
            else if (ch == 2)
            {
                Console.WriteLine("\n All Employees");
                foreach (Emp e in list)
                    Console.WriteLine(e.id + " " + e.name + " " + e.dept + " " + e.sal);
            }
            else if (ch == 3)
            {
                Console.Write("Enter ID to search: ");
                int id = int.Parse(Console.ReadLine());
                bool found = false;
                foreach (Emp e in list)
                    if (e.id == id)
                    {
                        Console.WriteLine(e.id + " " + e.name + " " + e.dept + " " + e.sal);
                        found = true;
                    }
                if (!found) Console.WriteLine("Employee not found!");
            }
            else if (ch == 4)
            {
                Console.Write("Enter ID to update: ");
                int id = int.Parse(Console.ReadLine());
                bool found = false;
                foreach (Emp e in list)
                    if (e.id == id)
                    {
                        Console.Write("New Name: "); e.name = Console.ReadLine();
                        Console.Write("New Dept: "); e.dept = Console.ReadLine();
                        Console.Write("New Salary: "); e.sal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Employee updated!");
                        found = true;
                    }
                if (!found) Console.WriteLine("Employee not found!");
            }
            else if (ch == 5)
            {
                Console.Write("Enter ID to delete: ");
                int id = int.Parse(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < list.Count; i++)
                    if (list[i].id == id)
                    {
                        list.RemoveAt(i);
                        Console.WriteLine("Employee deleted!");
                        found = true;
                        break;
                    }
                if (!found) Console.WriteLine("Employee not found!");
            }
            else if (ch == 6)
            {
                Console.WriteLine("Exiting Employee Management...");
            }
            else
            {
                Console.WriteLine("Invalid choice...");
            }
        }
    }
}
