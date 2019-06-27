using Colony.Core;
using Colony.Core.Ants.Getters;
using Colony.Core.Repositories;
using NSubstitute;
using Xunit;

namespace Colony.Tests
{
    public class DefaultAntsGetterTests
    {
        private IAntsRepository _repository;
        private IAntsGetter _getter;

        public DefaultAntsGetterTests()
        {
            _repository = Substitute.For<IAntsRepository>();
            _getter = new DefaultAntsGetter(_repository);
        }

        [Fact]
        public void should_get_all_living_ants()
        {
            _getter.Get();

            _repository.Received(1).Get();
        }
    }
}
