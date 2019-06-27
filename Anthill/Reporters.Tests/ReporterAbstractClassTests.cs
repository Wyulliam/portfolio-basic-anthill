using Cemetery.Core;
using Colony.Core;
using NSubstitute;
using Nursery.Core;
using Reporters.Core.Factory;
using Reporters.Core.Reporters.AnthillStatusReporter;
using Xunit;

namespace Reporters.Tests
{
    public class ReporterAbstractClassTests
    {
        private IReporterAbstractFactory _factory;
        private ICemetery _cemetery;
        private IColony _colony;
        private INursery _nursery;

        public ReporterAbstractClassTests()
        {
            _cemetery = Substitute.For<ICemetery>();
            _colony = Substitute.For<IColony>();
            _nursery = Substitute.For<INursery>();

            _factory = new ReporterAbstractFactory(_cemetery, _nursery, _colony);
        }

        [Fact]
        public void should_build_an_anthill_status_report()
        {
            var statusReporter = _factory.BuildStatusReporter();

            Assert.True(statusReporter is IAnthillStatusReporter);
        }
    }

}
