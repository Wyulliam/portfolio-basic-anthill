using Cemetery.Core.Corpses.Getters;
using Cemetery.Core.Repositories;
using NSubstitute;
using Xunit;

namespace Cemetery.Tests
{
    public class DefaultCorpseGetterTests
    {
        private ICorpseGetter _getter;
        private ICorpseRepository _repository;


        public DefaultCorpseGetterTests()
        {
            _repository = Substitute.For<ICorpseRepository>();
            _getter = new DefaultCorpseGetter(_repository);
        }

        [Fact]
        public void should_get_all_corpses()
        {
            _getter.Get();

            _repository.Received(1).Get();
        }
    }
}
