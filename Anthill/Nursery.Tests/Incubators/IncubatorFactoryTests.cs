using MediatR;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using Nursery.Core.Repositories;
using Xunit;

namespace Nursery.Tests.Incubators
{
    public class IncubatorFactoryTests
    {
        private IIncubatorFactory _factory;
        private IEggRepository _eggRepository;
        private IMediator _mediator;

        public IncubatorFactoryTests()
        {
            _factory = new IncubatorFactory(_eggRepository, _mediator);
        }

        [Fact]
        public void should_build_an_incubator()
        {
            var incubator = _factory.Build();

            Assert.True(incubator is IIncubator);
        }
    }

}
