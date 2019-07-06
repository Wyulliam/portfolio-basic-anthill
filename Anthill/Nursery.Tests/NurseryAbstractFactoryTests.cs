using MediatR;
using Nursery.Core;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using Nursery.Core.Repositories;
using Xunit;

namespace Nursery.Tests
{
    public class NurseryAbstractFactoryTests
    {
        private INurseryAbstractFactory _factory;
        private IAntTypeRepository _antTypeRepository;
        private IEggRepository _eggRepository;
        private IMediator _mediator;

        public NurseryAbstractFactoryTests()
        {
            _factory = new NurseryAbstractFactory(_antTypeRepository, _eggRepository, _mediator);
        }

        [Fact]
        public void should_build_an_ant_type_creator()
        {
            var antTypeCreator = _factory.BuildAntTypeCreator();

            Assert.True(antTypeCreator is IAntTypeCreator);
        }

        [Fact]
        public void should_build_an_ant_type_getter()
        {
            var antTypeGetter = _factory.BuildAntTypeGetter();

            Assert.True(antTypeGetter is IAntTypeGetter);
        }

        [Fact]
        public void should_build_an_incubator()
        {
            var incubator = _factory.BuildIncubator();

            Assert.True(incubator is IIncubator);
        }
    }
}
