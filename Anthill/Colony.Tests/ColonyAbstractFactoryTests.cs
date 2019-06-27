using Colony.Core.Ants.Getters;
using Colony.Core.Factory;
using Colony.Core.Repositories;
using NSubstitute;
using Xunit;

namespace Colony.Tests
{
    public class ColonyAbstractFactoryTests
    {
        private IColonyAbstractFactory _factory;

        public ColonyAbstractFactoryTests()
        {
            var antsRepository = Substitute.For<IAntsRepository>();
            _factory = new ColonyAbstractFactory(antsRepository);
        }

        [Fact]
        public void should_build_an_ant_getter_for_the_colony()
        {
            var getter = _factory.BuildAntsGetter();

            Assert.True(getter is IAntsGetter);
        }
    }
}
