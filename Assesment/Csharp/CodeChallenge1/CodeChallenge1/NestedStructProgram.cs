using System;
using System.Collections.Generic;

class NestedStructProgram
{
    public struct EmployeeStruct
    {
        public string Name { get; set; }
        public BirthDate DOB { get; set; }

        public struct BirthDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }
    }

    public void Run()
    {
        Console.Write("How many employees do you want to enter? ");
        int n = int.Parse(Console.ReadLine());

        EmployeeStruct[] employees = new EmployeeStruct[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEmployee " + (i + 1));
            Console.Write("Name: ");
            employees[i].Name = Console.ReadLine();

            Console.Write("Day of Birth: ");
            employees[i].DOB.Day = int.Parse(Console.ReadLine());

            Console.Write("Month of Birth: ");
            employees[i].DOB.Month = int.Parse(Console.ReadLine());

            Console.Write("Year of Birth: ");
            employees[i].DOB.Year = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Employee Details ---");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Name: " + employees[i].Name + ", DOB: " +
                              employees[i].DOB.Day + "-" +
                              employees[i].DOB.Month + "-" +
                              employees[i].DOB.Year);
        }
    }
}