using System.Collections.Generic;

namespace FactoryAndStrategy.Report
{
    public interface IReportService
    {
        List<UserReport> GetReportByTypeUsingManualMapping(ReportType reportType);

        object GetReportByTypeUsingAutoMapper(ReportType reportType);

    }
}
