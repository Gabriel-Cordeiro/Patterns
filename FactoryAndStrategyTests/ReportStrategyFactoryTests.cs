using FactoryAndStrategy.Report;
using Xunit;

namespace FactoryAndStrategyTests
{
    public class ReportStrategyFactoryTests
    {
        [Fact]
        public void Report_Should_Be_Common_When_Report_Type_Is_Common()
        {
            var reportTypeCommon = ReportStrategyFactory.GetReportByType(ReportType.Common);

            Assert.IsType<CommonUserReport>(reportTypeCommon);
        }

        [Fact]
        public void Report_Should_Be_Manager_When_Report_Type_Is_Manager()
        {
            var reportTypeCommon = ReportStrategyFactory.GetReportByType(ReportType.Manager);

            Assert.IsType<ManagerUserReport>(reportTypeCommon);
        }
    }
}
