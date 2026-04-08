using System;

namespace CodeChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Student Program ----");
            StudentProgram.Run();
            Console.WriteLine("\n---- Product Program ----");
            ProductProgram.Run();
            Console.WriteLine("\n---- Exception Program ----");
            ExceptionProgram.Run();
            Console.WriteLine("\n---- Delegate Program ----");
            DelegateProgram.Run();
        }
    }
}