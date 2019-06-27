using Cemetery.Core;
using Cemetery.Core.Corpses.Getters;
using NSubstitute;
using Xunit;

namespace Cemetery.Tests
{
    public class CemeteryTests
    {
        private ICemetery _cemetery;
        private ICorpseGetter _corpseGetter;

        public CemeteryTests()
        {
            _corpseGetter = Substitute.For<ICorpseGetter>();
            _cemetery = new Core.Cemetery(_corpseGetter);
        }

        [Fact]
        public void should_get_all_dead_ants_corpses()
        {
            _cemetery.GetCorpses();

            _corpseGetter.Received(1).Get();
        }
    }
}
