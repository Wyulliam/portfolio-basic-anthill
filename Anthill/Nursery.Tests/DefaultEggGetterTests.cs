using NSubstitute;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Repositories.Internal;
using Xunit;

namespace Nursery.Tests
{
    public class DefaultEggGetterTests
    {
        private IEggGetter _getter;
        private IEggRepository _repository;

        public DefaultEggGetterTests()
        {
            _repository = Substitute.For<IEggRepository>();
            _getter = new DefaultEggGetter(_repository);
        }

        [Fact]
        public void should_get_all_incubating_eggs()
        {
            _getter.Get();

            _repository.Received(1).Get();
        }
    }
}
