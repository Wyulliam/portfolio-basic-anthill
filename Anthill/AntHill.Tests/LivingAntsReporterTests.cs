using Anthill.Core;
using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace AntHill.Tests
{
    public class LivingAntsReporterTests
    {
        private IReporter _reporter;
        private IColonyRepository _colonyRepository;

        public LivingAntsReporterTests()
        {
            _colonyRepository = Substitute.For<IColonyRepository>();
            _reporter = new LivingAntsReporter(_colonyRepository);
        }

        [Fact]
        public void should_get_how_many_ants_are_alive()
        {
            _reporter.Report();

            _colonyRepository.Received(1).GetAnts();
        }

        [Fact]
        public void should_report_how_many_ants_are_alive()
        {
            _colonyRepository.GetAnts().Returns(new List<AntsDTO>() { new AntsDTO(5, "Warrior"), new AntsDTO(10, "Workers") });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Workers");
        }
    }
}
