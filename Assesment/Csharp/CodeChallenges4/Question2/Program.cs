using System;
using CodeChallenges4.Question2.Interface;
using CodeChallenges4.Question2.Factory;

namespace CodeChallenges4.Question2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Report Type (Chart / Tabular / Summary):");
            string input = Console.ReadLine();

            IReportGenerator report = null;

            if (input == "Chart")
            {
                report = new ChartFactory().Create();
            }
            else if (input == "Tabular")
            {
                report = new TabularFactory().Create();
            }
            else if (input == "Summary")
            {
                report = new SummaryFactory().Create();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            report.GenerateReport();
        }
    }
}