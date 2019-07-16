using FluentAssertions;
using NSubstitute;
using Nursery.Core.Eggs.Checker;
using Nursery.Core.Eggs.Checker.Factory;
using Nursery.Core.Eggs.DTOs;
using Reporters.Core.Reporters.StatusReporters;
using System.Collections.Generic;
using Xunit;

namespace Reporters.Tests
{
    public class EggsIncubatingReporterTests
    {
        private StatusReporter _reporter;
        private IEggsChecker _eggsChecker;

        public EggsIncubatingReporterTests()
        {
            _eggsChecker = Substitute.For<IEggsChecker>();
            var eggsCheckerFactory = Substitute.For<IEggsCheckerFactory>();
            eggsCheckerFactory.Build().Returns(_eggsChecker);

            _reporter = new EggsIncubatingReporter(eggsCheckerFactory);
        }

        [Fact]
        public void should_get_how_many_eggs_are_incubating()
        {
            _reporter.Report();

            _eggsChecker.Received(1).CheckEggs();
        }

        [Fact]
        public void should_report_how_many_eggs_are_incubating()
        {
            _eggsChecker.CheckEggs().Returns(new List<EggsDTO>() { new EggsDTO("Warrior", 5), new EggsDTO("Worker", 10) });

            var report = _reporter.Report();

            report.Should().Contain("5");
            report.Should().Contain("10");
            report.Should().Contain("Warrior");
            report.Should().Contain("Worker");
        }
    }
}
