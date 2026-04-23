using CodeChallenges4.Question2.Interface;
using CodeChallenges4.Question2.Concrete;

namespace CodeChallenges4.Question2.Factory
{
    public class ChartFactory
    {
        public IReportGenerator Create()
        {
            return new ChartReport();
        }
    }
}