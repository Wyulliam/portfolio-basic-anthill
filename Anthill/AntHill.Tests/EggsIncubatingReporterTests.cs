using Anthill.Core;
using FluentAssertions;
using NSubstitute;
using Nursery.Core;
using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;
using Xunit;

namespace AntHill.Tests
{
    public class EggsIncubatingReporterTests
    {
        private IReporter _reporter;
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
            _nursery.GetEggs().Returns(new List<EggsDTO>() { new EggsDTO(5, "Warrior"), new EggsDTO(10, "Worker") });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Worker");
        }
    }
}
