using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAndStrategy.Report
{
    public abstract class UserReport
    {
        protected UserReport(ReportType reportType)
        {
            ReportType = reportType;
        }

        public ReportType ReportType { get; set; }

        public abstract void MapUser(User user);

    }
}
