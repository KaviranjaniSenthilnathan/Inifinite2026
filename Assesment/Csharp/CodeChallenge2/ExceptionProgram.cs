using System;

namespace CodeChallenge2
{
    class ExceptionProgram
    {
        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }
            Console.WriteLine("Number is valid: " + number);
        }
        public static void Run()
        {
            try
            {
                Console.Write("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());

                CheckNumber(num);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}