using Colony.Core;
using Colony.Core.Ants.DTOs;
using FluentAssertions;
using NSubstitute;
using Reporters.Core.Reporters.StatusReporters;
using System.Collections.Generic;
using Xunit;

namespace Reporters.Tests
{
    public class LivingAntsReporterTests
    {
        private StatusReporter _reporter;
        private IColony _colony;

        public LivingAntsReporterTests()
        {
            _colony = Substitute.For<IColony>();
            _reporter = new LivingAntsReporter(_colony);
        }

        [Fact]
        public void should_get_how_many_ants_are_alive()
        {
            _reporter.Report();

            _colony.Received(1).GetAnts();
        }

        [Fact]
        public void should_report_how_many_ants_are_alive()
        {
            _colony.GetAnts().Returns(new List<AntsDTO>() { new AntsDTO(5, "Warrior"), new AntsDTO(10, "Workers") });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Workers");
        }
    }
}
