using Cemetery.Core.Corpses.Getters;
using Cemetery.Core.Factory;
using Cemetery.Core.Repositories;
using NSubstitute;
using Xunit;

namespace Cemetery.Tests
{
    public class CemeteryAbstractFactoryTests
    {
        private ICemeteryAbstractFactory _factory;
        private ICorpseRepository _repository;

        public CemeteryAbstractFactoryTests()
        {
            _repository = Substitute.For<ICorpseRepository>();
            _factory = new CemeteryAbstractFactory(_repository);
        }

        [Fact]
        public void should_build_a_corpse_getter()
        {
            var corpseGetter = _factory.BuildCorpseGetter();

            Assert.True(corpseGetter is ICorpseGetter);
        }
    }
}
