using Anthill.Core;
using NSubstitute;
using Xunit;

namespace AntHill.Tests
{
    public class NurseryTests
    {
        private INursery _nursery;
        private IEggGenerator _eggGenerator;
        private IAntTypeCreator _typeCreator;
        private IAntTypeGetter _typeGetter;

        public NurseryTests()
        {
            _eggGenerator = Substitute.For<IEggGenerator>();
            _typeCreator = Substitute.For<IAntTypeCreator>();
            _typeGetter = Substitute.For<IAntTypeGetter>();
            _nursery = new Nursery(_eggGenerator, _typeCreator, _typeGetter);
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

    }
}
