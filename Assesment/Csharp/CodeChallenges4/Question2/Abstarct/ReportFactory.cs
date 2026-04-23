using CodeChallenges4.Question2.Interface;

namespace CodeChallenges4.Question2.Abstract
{
    public abstract class ReportFactory
    {
        public abstract IReportGenerator CreateReport();
    }
}