using AutoMapper;

using FactoryAndStrategy.Report;
using System;
using System.Collections.Generic;

namespace FactoryAndStrategy
{
    public class Program
    {
        private static List<UserReport> _reports = new List<UserReport>();
        private static List<User> _users = CreateListOfUsers();

        static void Main(string[] args)
        {
            var mapper = ConfigureAutoMapper();
            var reportType = ReportStrategyFactory.GetReportByType(ReportType.Comum);

            var reportList = GetEmptyReportList(reportType);

            var commonReportUsingAutoMapper = mapper.Map(_users, reportList);

            _users.ForEach(user =>
            {
                reportType.MapUser(user);
                _reports.Add(reportType);
            });

            Console.WriteLine(reportType);
            Console.WriteLine(_reports);
        }

        private static object GetEmptyReportList(UserReport reportType)
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
    }
}
