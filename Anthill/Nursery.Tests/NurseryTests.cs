using NSubstitute;
using Nursery.Core;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.Getters;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using Xunit;

namespace Nursery.Tests
{
    public class NurseryTests
    {
        private INursery _nursery;
        private IIncubator _incubator;
        private IAntTypeCreator _typeCreator;
        private IAntTypeGetter _typeGetter;

        private INurseryAbstractFactory _factory;

        public NurseryTests()
        {
            _incubator = Substitute.For<IIncubator>();
            _typeCreator = Substitute.For<IAntTypeCreator>();
            _typeGetter = Substitute.For<IAntTypeGetter>();

            _factory = Substitute.For<INurseryAbstractFactory>();
            _factory.BuildAntTypeCreator().Returns(_typeCreator);
            _factory.BuildAntTypeGetter().Returns(_typeGetter);
            _factory.BuildIncubator().Returns(_incubator);

            _nursery = new Core.Nursery(_factory);
        }

        [Fact]
        public void should_generate_eggs_when_incubating()
        {
            _nursery.IncubateEggs("Warrior", 5);

            // _incubator.Received(1).Incubate(
              //  Arg.Is<EggsDTO>(a => a.Type == "Warrior" && a.Quantity == 5));
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

            _incubator.Received(1).GetEggs();
        }
    }
}
