using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("...Program 1: Employee Management System...");
        EmpProgram empProgram = new EmpProgram();
        empProgram.Run();

        Console.WriteLine("\n...Program 2: Nested Struct Example...");
        NestedStructProgram nestedProgram = new NestedStructProgram();
        nestedProgram.Run();
    }
}