using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelConcessionLibrary;

namespace Assignment7
{
    

    class Program4
    {
        // TotalFare as constant
        public const decimal TotalFare = 500;

        static void Main()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Concession concession = new Concession();

            string result = concession.CalculateConcession(age, TotalFare);

            Console.WriteLine($"\nPassenger Name: {name}");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}
