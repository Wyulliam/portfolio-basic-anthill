using MediatR;
using NSubstitute;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Factory;
using Nursery.Core.Repositories;
using Xunit;

namespace Nursery.Tests
{
    public class NurseryAbstractFactoryTests
    {
        private INurseryAbstractFactory _factory;
        private IAntTypeRepository _antTypeRepository;
        private IIncubatorFactory _incubatorFactory;

        public NurseryAbstractFactoryTests()
        {
            _incubatorFactory = Substitute.For<IIncubatorFactory>();

            _factory = new NurseryAbstractFactory(_antTypeRepository,
                _incubatorFactory);
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

            _incubatorFactory.Received(1).Build();
        }
    }

}
