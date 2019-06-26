using System.Collections.Generic;
using System.Text;

namespace Anthill.Core
{
    class DefaultStatusReporter : IStatusReporter
    {
        private List<IReporter> _reporters;

        public DefaultStatusReporter(params IReporter[] reporters)
        {
            _reporters = new List<IReporter>();
            _reporters.AddRange(reporters);
        }

        public string Report()
        {
            var report = new StringBuilder();

            foreach (var reporter in _reporters)
            {
                report.Append(reporter.Report());
            }

            return report.ToString();
        }
    }
}
