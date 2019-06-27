using FluentAssertions;
using NSubstitute;
using Reporters.Core;
using Reporters.Core.Reporters;
using Xunit;

namespace Reporters.Tests
{
    public class DefaultStatusReporterTests
    {
        private IStatusReporter _statusReporter;
        private IReporter _randomReporter1;
        private IReporter _randomReporter2;

        public DefaultStatusReporterTests()
        {
            _randomReporter1 = Substitute.For<IReporter>();
            _randomReporter2 = Substitute.For<IReporter>();

            _statusReporter = new DefaultStatusReporter(_randomReporter1, _randomReporter2);
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
