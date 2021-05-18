using FactoryAndStrategy.Report;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FactoryAndStrategyTests
{
    public class ReportServiceTests
    {
        private readonly IReportService _reportService;

        public ReportServiceTests()
        {
            _reportService = new ReportService();
        }

        [Fact]
        public void Should_Return_Common_Report_When_Report_Type_Is_Common_Using_Manual_Mapping()
        {
            var commonReport = _reportService.GetReportByTypeUsingManualMapping(ReportType.Common);

            Assert.True(typeof(CommonUserReport) == commonReport.FirstOrDefault().GetType());
        }

        [Fact]
        public void Should_Return_Manager_Report_When_Report_Type_Is_Manager_Using_Manual_Mapping()
        {
            var managerReport = _reportService.GetReportByTypeUsingManualMapping(ReportType.Manager);

            Assert.True(typeof(ManagerUserReport) == managerReport.FirstOrDefault().GetType());
        }

        [Fact]
        public void Should_Return_Common_Report_When_Report_Type_Is_Common_Using_AutoMapper_Mapping()
        {
            var commonReport = (List<CommonUserReport>)_reportService.GetReportByTypeUsingAutoMapper(ReportType.Common);

            Assert.True(typeof(CommonUserReport) == commonReport.FirstOrDefault().GetType());
        }

        [Fact]
        public void Should_Return_Manager_Report_When_Report_Type_Is_Manager_Using_AutoMapper_Mapping()
        {
            var managerReport = (List<ManagerUserReport>)_reportService.GetReportByTypeUsingAutoMapper(ReportType.Manager);

            Assert.True(typeof(ManagerUserReport) == managerReport.FirstOrDefault().GetType());
        }
    }
}
