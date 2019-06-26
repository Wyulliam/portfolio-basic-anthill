using Anthill.Core;
using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace AntHill.Tests
{
    public class DeadAntsReporterTests
    {
        private IReporter _reporter;
        private ICemeteryRepository _cemeteryRepository;

        public DeadAntsReporterTests()
        {
            _cemeteryRepository = Substitute.For<ICemeteryRepository>();
            _reporter = new DeadAntsReporter(_cemeteryRepository);
        }

        [Fact]
        public void should_get_how_many_ants_are_dead()
        {
            _reporter.Report();

            _cemeteryRepository.Received(1).GetCorpses();
        }

        [Fact]
        public void should_report_how_many_ants_are_dead()
        {
            _cemeteryRepository.GetCorpses().Returns(new List<CorpsesDTO>() { new CorpsesDTO(5, "Warrior"), new CorpsesDTO(10, "Workers") });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Workers");
        }
    }
}
