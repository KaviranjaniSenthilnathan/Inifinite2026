using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 7, 2, 30 };

            var result = from n in numbers
                         let square = n * n
                         where square > 20
                         select new { Number = n, Square = square };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }
        }
    }
}
