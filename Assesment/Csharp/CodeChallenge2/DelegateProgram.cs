using System;

namespace CodeChallenge2
{
    class DelegateProgram
    {
        public delegate int CalculatorDelegate(int a, int b);

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;

        public static void Run()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            CalculatorDelegate operation = null;

            if (choice == 1)
                operation = Add;
            else if (choice == 2)
                operation = Subtract;
            else if (choice == 3)
                operation = Multiply;
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            int result = operation(num1, num2);
            Console.WriteLine("Result: " + result);
        }
    }
}