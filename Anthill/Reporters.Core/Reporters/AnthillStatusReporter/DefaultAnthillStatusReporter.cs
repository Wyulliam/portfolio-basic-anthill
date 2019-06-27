using Reporters.Core.Reporters.StatusReporters;
using System.Collections.Generic;
using System.Text;

namespace Reporters.Core.Reporters.AnthillStatusReporter
{
    class DefaultAnthillStatusReporter : IAnthillStatusReporter
    {
        private List<StatusReporter> _reporters;

        public DefaultAnthillStatusReporter(params StatusReporter[] reporters)
        {
            _reporters = new List<StatusReporter>();
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
