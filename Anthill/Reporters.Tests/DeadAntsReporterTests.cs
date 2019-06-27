using Cemetery.Core;
using Cemetery.Core.Corpses.DTOs;
using FluentAssertions;
using NSubstitute;
using Reporters.Core.Reporters;
using System.Collections.Generic;
using Xunit;

namespace Reporters.Tests
{
    public class DeadAntsReporterTests
    {
        private IReporter _reporter;
        private ICemetery _cemetery;

        public DeadAntsReporterTests()
        {
            _cemetery = Substitute.For<ICemetery>();
            _reporter = new DeadAntsReporter(_cemetery);
        }

        [Fact]
        public void should_get_how_many_ants_are_dead()
        {
            _reporter.Report();

            _cemetery.Received(1).GetCorpses();
        }

        [Fact]
        public void should_report_how_many_ants_are_dead()
        {
            _cemetery.GetCorpses().Returns(new List<CorpsesDTO>() { new CorpsesDTO(5, "Warrior"), new CorpsesDTO(10, "Workers") });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Workers");
        }
    }
}
