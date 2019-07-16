using NSubstitute;
using Nursery.Core.Eggs.Checker;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using Xunit;

namespace Nursery.Tests.Egg
{
    public class DefaultEggCheckerTests
    {
        private IEggsChecker _checker;
        private IIncubator _incubator;

        public DefaultEggCheckerTests()
        {
            var incubatorFactory = Substitute.For<IIncubatorFactory>();
            _incubator = Substitute.For<IIncubator>();
            incubatorFactory.Build().Returns(_incubator);

            _checker = new DefaultEggsChecker(incubatorFactory);
        }

        [Fact]
        public void should_check_all_eggs_incubating()
        {
            _checker.CheckEggs();

            _incubator.Received(1).GetEggs();
        }
    }

}
