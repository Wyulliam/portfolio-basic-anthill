using NSubstitute;
using Nursery.Core.Eggs.Checker;
using Nursery.Core.Eggs.Checker.Factory;
using Nursery.Core.Factory;
using Xunit;

namespace Nursery.Tests.Egg
{
    public class EggsCheckFactoryTest
    {
        private IEggsCheckerFactory _factory;

        public EggsCheckFactoryTest()
        {
            var incubatorFactory = Substitute.For<IIncubatorFactory>();
            _factory = new EggsCheckerFactory(incubatorFactory);
        }

        [Fact]
        public void should_build_an_eggs_checker()
        {
            var checker = _factory.Build();

            Assert.True(checker is IEggsChecker);
        }
    }

}
