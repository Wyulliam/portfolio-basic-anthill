using Colony.Core;
using Colony.Core.Ants.Getters;
using NSubstitute;
using Xunit;

namespace Colony.Tests
{
    public class ColonyTests
    {
        private IColony _colony;
        private IAntsGetter _antsGetter;

        public ColonyTests()
        {
            _antsGetter = Substitute.For<IAntsGetter>();
            _colony = new Core.Colony(_antsGetter);
        }

        [Fact]
        public void should_get_all_living_ants()
        {
            _colony.GetAnts();

            _antsGetter.Received(1).Get();
        }
    }
}
