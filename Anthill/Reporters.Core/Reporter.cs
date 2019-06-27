using Reporters.Core.Factory;
using Reporters.Core.Reporters.AnthillStatusReporter;

namespace Reporters.Core
{
    class Reporter : IReporter
    {
        private readonly IAnthillStatusReporter _statusReporter;

        public Reporter(IReporterAbstractFactory factory)
        {
            _statusReporter = factory.BuildStatusReporter();
        }

        public string Report()
        {
            return _statusReporter.Report();
        }
    }
}
