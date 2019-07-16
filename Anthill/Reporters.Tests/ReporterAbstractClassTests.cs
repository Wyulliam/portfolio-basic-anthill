using Cemetery.Core;
using Colony.Core;
using NSubstitute;
using Nursery.Core.Eggs.Checker.Factory;
using Reporters.Core.Factory;
using Reporters.Core.Reporters.AnthillStatusReporter;
using Xunit;

namespace Reporters.Tests
{
    public class ReporterAbstractClassTests
    {
        private IReporterAbstractFactory _factory;

        public ReporterAbstractClassTests()
        {
            var cemetery = Substitute.For<ICemetery>();
            var colony = Substitute.For<IColony>();
            var eggsCheckerFactory = Substitute.For<IEggsCheckerFactory>();

            _factory = new ReporterAbstractFactory(cemetery, eggsCheckerFactory, colony);
        }

        [Fact]
        public void should_build_an_anthill_status_report()
        {
            var statusReporter = _factory.BuildStatusReporter();

            Assert.True(statusReporter is IAnthillStatusReporter);
        }
    }

}
