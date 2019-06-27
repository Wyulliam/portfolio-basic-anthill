using Colony.Core;
using Colony.Core.Ants.Getters;
using Colony.Core.Factory;
using NSubstitute;
using Xunit;

namespace Colony.Tests
{
    public class ColonyTests
    {
        private IColony _colony;
        private IAntsGetter _antsGetter;
        private IColonyAbstractFactory _factory;

        public ColonyTests()
        {
            _antsGetter = Substitute.For<IAntsGetter>();
            _factory = Substitute.For<IColonyAbstractFactory>();

            _factory.BuildAntsGetter().Returns(_antsGetter);

            _colony = new Core.Colony(_factory);
        }

        [Fact]
        public void should_get_all_living_ants()
        {
            _colony.GetAnts();

            _antsGetter.Received(1).Get();
        }
    }
}
