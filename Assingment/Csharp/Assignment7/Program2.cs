using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
   
    class Program2
    {
        static void Main()
        {
            List<string> words = new List<string>
        {
            "mum", "amsterdam", "bloom"
        };

            var result = from word in words
                         where word.StartsWith("a") && word.EndsWith("m")
                         select word;

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
