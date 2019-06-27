using Nursery.Core;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Repositories;
using Xunit;

namespace AntHill.Tests
{
    public class NurseryAbstractFactoryTests
    {
        private INurseryAbstractFactory _factory;
        private IAntTypeRepository _antTypeRepository;
        private IEggRepository _eggRepository;

        public NurseryAbstractFactoryTests()
        {
            _factory = new NurseryAbstractFactory(_antTypeRepository, _eggRepository);
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
        public void should_build_an_egg_generator()
        {
            var eggGenerator = _factory.BuildEggGenerator();

            Assert.True(eggGenerator is IEggGenerator);
        }

        [Fact]
        public void should_build_an_egg_getter()
        {
            var eggGetter = _factory.BuildEggGetter();

            Assert.True(eggGetter is IEggGetter);
        }
    }
}
