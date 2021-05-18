using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace FactoryAndStrategy.Report
{
    public class ReportStrategyFactory
    {
        private static readonly IReadOnlyDictionary<ReportType, UserReport> _strategies =
            typeof(UserReport).Assembly.ExportedTypes
            .Where(t => typeof(UserReport).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(x => Activator.CreateInstance(x))
            .Cast<UserReport>()
            .ToImmutableDictionary(x => x.ReportType, x => x);

        public static UserReport GetReportByType(ReportType type)
        {
            _strategies.TryGetValue(type, out UserReport report);
            return report ?? throw new Exception("Tipo invalido");
        }
    }
}
