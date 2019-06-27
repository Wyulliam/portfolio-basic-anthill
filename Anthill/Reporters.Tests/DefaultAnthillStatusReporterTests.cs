using FluentAssertions;
using NSubstitute;
using Reporters.Core.Reporters.AnthillStatusReporter;
using Reporters.Core.Reporters.StatusReporters;
using Xunit;

namespace Reporters.Tests
{
    public class DefaultAnthillStatusReporterTests
    {
        private IAnthillStatusReporter _statusReporter;
        private StatusReporter _randomReporter1;
        private StatusReporter _randomReporter2;

        public DefaultAnthillStatusReporterTests()
        {
            _randomReporter1 = Substitute.For<StatusReporter>();
            _randomReporter2 = Substitute.For<StatusReporter>();

            _statusReporter = new DefaultAnthillStatusReporter(_randomReporter1, _randomReporter2);
        }

        [Fact]
        public void should_gatter_information_from_all_the_reporters()
        {
            var report1 = "This is the random report 1";
            var report2 = "This is the random report 2";

            _randomReporter1.Report().Returns(report1);
            _randomReporter2.Report().Returns(report2);

            var report = _statusReporter.Report();

            report.Should().Contain(report1);
            report.Should().Contain(report2);
        }
    }
}
