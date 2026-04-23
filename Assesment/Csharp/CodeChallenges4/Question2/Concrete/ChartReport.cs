using System;
using CodeChallenges4.Question2.Interface;

namespace CodeChallenges4.Question2.Concrete
{
    public class ChartReport : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating CHART Report...");
        }
    }
}