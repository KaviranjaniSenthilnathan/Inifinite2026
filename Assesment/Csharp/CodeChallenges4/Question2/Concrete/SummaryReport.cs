using System;
using CodeChallenges4.Question2.Interface;

namespace CodeChallenges4.Question2.Concrete
{
    public class SummaryReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating SUMMARY Report...");
        }
    }
}