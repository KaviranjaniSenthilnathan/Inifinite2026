using System;

namespace CodeChallenge2
{ 
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
     class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
     class StudentProgram
    {
        public static void Run()
        {
            Undergraduate ug = new Undergraduate
            {
                Name = "Rahul",
                StudentId = 101,
                Grade = 75.5
            };
            Console.WriteLine("Undergraduate Student:");
            Console.WriteLine($"Name: {ug.Name}");
            Console.WriteLine($"Passed: {ug.IsPassed(ug.Grade)}");
            Console.WriteLine();
            Graduate grad = new Graduate
            {
                Name = "Sneha",
                StudentId = 202,
                Grade = 78.0
            };
            Console.WriteLine("Graduate Student:");
            Console.WriteLine($"Name: {grad.Name}");
            Console.WriteLine($"Passed: {grad.IsPassed(grad.Grade)}");
        }
    }
}