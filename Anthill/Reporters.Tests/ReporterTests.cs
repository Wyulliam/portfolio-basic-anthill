using NSubstitute;
using Reporters.Core;
using Reporters.Core.Factory;
using Reporters.Core.Reporters.AnthillStatusReporter;
using Xunit;

namespace Reporters.Tests
{
    public class ReporterTests
    {
        private IReporter _reporter;
        private IReporterAbstractFactory _factory;
        private IAnthillStatusReporter _statusReporter;

        public ReporterTests()
        {
            _factory = Substitute.For<IReporterAbstractFactory>();
            _statusReporter = Substitute.For<IAnthillStatusReporter>();

            _factory.BuildStatusReporter().Returns(_statusReporter);

            _reporter = new Reporter(_factory);

        }

        [Fact]
        public void should_report_the_anthill_current_status()
        {
            _reporter.Report();

            _statusReporter.Received(1).Report();
        }
    }

}
