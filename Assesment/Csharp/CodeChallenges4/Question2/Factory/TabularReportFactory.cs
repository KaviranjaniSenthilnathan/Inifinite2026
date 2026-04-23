using CodeChallenges4.Question2.Interface;
using CodeChallenges4.Question2.Concrete;

namespace CodeChallenges4.Question2
{
    public class TabularReportFactory
    {
        public IReportGenerator Create()
        {
            return new TabularReport();
        }
    }
}