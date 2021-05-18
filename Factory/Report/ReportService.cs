using AutoMapper;
using System;
using System.Collections.Generic;

namespace FactoryAndStrategy.Report
{
    public class ReportService : IReportService
    {
        public object GetReportByTypeUsingAutoMapper(ReportType reportType)
        {
            var mapper = ConfigureAutoMapper();
            var reportStrategy = ReportStrategyFactory.GetReportByType(reportType);

            var reportList = GetEmptyListForSpecificStrategy(reportStrategy);

            var report = mapper.Map(CreateListOfUsers(), reportList);
            
            return report;
        }

        public List<UserReport> GetReportByTypeUsingManualMapping(ReportType reportType)
        {
            var strategy = ReportStrategyFactory.GetReportByType(reportType);
            var reports = new List<UserReport>();

            CreateListOfUsers().ForEach(user =>
            {
                reports.Add(strategy.GetReport(user));
            });

            return reports;
        }


        #region Private methods

        private static object GetEmptyListForSpecificStrategy(UserReport reportType)
        {
            var listType = typeof(List<>);
            var constructedListType = listType.MakeGenericType(reportType.GetType());

            var instance = Activator.CreateInstance(constructedListType);
            return instance;
        }

        private static Mapper ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, ManagerUserReport>();
                cfg.CreateMap<User, CommonUserReport>();
            });
            return new Mapper(config);
        }

        private static List<User> CreateListOfUsers()
        {
            var user = new User(1, "Gabriel", "test@test", "1111111111", "teste");
            var users = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                users.Add(user);
            }

            return users;
        }

        #endregion
    }
}
