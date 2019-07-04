using FluentAssertions;
using NSubstitute;
using Nursery.Core;
using Nursery.Core.Eggs.DTOs;
using Reporters.Core.Reporters.StatusReporters;
using System.Collections.Generic;
using Xunit;

namespace Reporters.Tests
{
    public class EggsIncubatingReporterTests
    {
        private StatusReporter _reporter;
        private INursery _nursery;

        public EggsIncubatingReporterTests()
        {
            _nursery = Substitute.For<INursery>();
            _reporter = new EggsIncubatingReporter(_nursery);
        }

        [Fact]
        public void should_get_how_many_eggs_are_incubating()
        {
            _reporter.Report();

            _nursery.Received(1).GetEggs();
        }

        [Fact]
        public void should_report_how_many_eggs_are_incubating()
        {
            _nursery.GetEggs().Returns(new List<EggsDTO>() { new EggsDTO("Warrior", 5), new EggsDTO("Worker", 10) });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Worker");
        }
    }
}
