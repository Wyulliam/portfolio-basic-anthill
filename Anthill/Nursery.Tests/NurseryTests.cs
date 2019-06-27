using NSubstitute;
using Nursery.Core;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Factory;
using Xunit;

namespace AntHill.Tests
{
    public class NurseryTests
    {
        private INursery _nursery;
        private IEggGenerator _eggGenerator;
        private IEggGetter _eggGetter;
        private IAntTypeCreator _typeCreator;
        private IAntTypeGetter _typeGetter;

        private INurseryAbstractFactory _factory;

        public NurseryTests()
        {
            _eggGetter = Substitute.For<IEggGetter>();
            _eggGenerator = Substitute.For<IEggGenerator>();
            _typeCreator = Substitute.For<IAntTypeCreator>();
            _typeGetter = Substitute.For<IAntTypeGetter>();

            _factory = Substitute.For<INurseryAbstractFactory>();
            _factory.BuildEggGetter().Returns(_eggGetter);
            _factory.BuildEggGenerator().Returns(_eggGenerator);
            _factory.BuildAntTypeCreator().Returns(_typeCreator);
            _factory.BuildAntTypeGetter().Returns(_typeGetter);

            _nursery = new Nursery.Core.Nursery(_factory);
        }

        [Fact]
        public void should_generate_eggs_when_incubating()
        {
            _nursery.IncubateEggs(5, "Warrior");

            _eggGenerator.Received(1).Generate(5, "Warrior");
        }

        [Fact]
        public void should_create_new_type_of_ants()
        {
            _nursery.CreateType("Warrior");

            _typeCreator.Received(1).Create("Warrior");
        }

        [Fact]
        public void should_get_all_ant_types()
        {
            _nursery.GetAntTypes();

            _typeGetter.Received(1).Get();
        }

        [Fact]
        public void should_get_how_many_eggs_are_incubating()
        {
            _nursery.GetEggs();

            _eggGetter.Received(1).Get();
        }
    }
}
