using AutoMapper;

using FactoryAndStrategy.Report;
using System;
using System.Collections.Generic;

namespace FactoryAndStrategy
{
    public class Program
    {
        private static IReportService _reportService = new ReportService();


        static void Main(string[] args)
        {
            #region Manual mapping

            //var commonReport = _reportService.GetReportByTypeUsingManualMapping(ReportType.Common);
            //var ManagerReport = _reportService.GetReportByTypeUsingManualMapping(ReportType.Manager);

            //Console.WriteLine(commonReport.GetType());
            //Console.WriteLine(ManagerReport.GetType());
            //Console.WriteLine(commonReport);
            //Console.WriteLine(ManagerReport);
            //Console.ReadLine();

            #endregion

            #region Using AutoMapper

            var commonReportAutoMapper = _reportService.GetReportByTypeUsingAutoMapper(ReportType.Common);
            var ManagerReportAutoMapper = _reportService.GetReportByTypeUsingAutoMapper(ReportType.Manager);

            Console.WriteLine(commonReportAutoMapper.GetType());
            Console.WriteLine(ManagerReportAutoMapper.GetType());
            Console.WriteLine(commonReportAutoMapper);
            Console.WriteLine(ManagerReportAutoMapper);
            Console.ReadLine();

            #endregion

        }
    }
}
