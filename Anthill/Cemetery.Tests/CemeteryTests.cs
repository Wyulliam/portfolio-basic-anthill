using Cemetery.Core;
using Cemetery.Core.Corpses.Getters;
using Cemetery.Core.Factory;
using NSubstitute;
using Xunit;

namespace Cemetery.Tests
{
    public class CemeteryTests
    {
        private ICemetery _cemetery;
        private ICorpseGetter _corpseGetter;

        private ICemeteryAbstractFactory _factory;

        public CemeteryTests()
        {
            _corpseGetter = Substitute.For<ICorpseGetter>();
            _factory = Substitute.For<ICemeteryAbstractFactory>();

            _factory.BuildCorpseGetter().Returns(_corpseGetter);

            _cemetery = new Core.Cemetery(_factory);
        }

        [Fact]
        public void should_get_all_dead_ants_corpses()
        {
            _cemetery.GetCorpses();

            _corpseGetter.Received(1).Get();
        }
    }
}
