using AutoMapper;

using FactoryAndStrategy.Report;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryAndStrategy
{
    public class Program
    {
        private static IReportService _reportService = new ReportService();


        static void Main(string[] args)
        {
            #region Manual mapping

            var commonReport = _reportService.GetReportByTypeUsingManualMapping(ReportType.Common);
            var ManagerReport = _reportService.GetReportByTypeUsingManualMapping(ReportType.Manager);

            Console.WriteLine(commonReport.FirstOrDefault().GetType());
            Console.WriteLine(ManagerReport.FirstOrDefault().GetType());
            Console.ReadLine();

            #endregion

            #region Using AutoMapper

            var commonReportAutoMapper = _reportService.GetReportByTypeUsingAutoMapper(ReportType.Common);
            var ManagerReportAutoMapper = _reportService.GetReportByTypeUsingAutoMapper(ReportType.Manager);

            Console.WriteLine(commonReportAutoMapper.GetType());
            Console.WriteLine(ManagerReportAutoMapper.GetType());
            Console.ReadLine();

            #endregion

        }
    }
}
