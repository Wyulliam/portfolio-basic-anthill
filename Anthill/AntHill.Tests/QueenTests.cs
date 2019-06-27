using Anthill.Core;
using NSubstitute;
using Nursery.Core;
using Reporters.Core;
using Xunit;

namespace AntHill.Tests
{
    public class QueenTests
    {
        private readonly IQueen _queen;
        private readonly INursery _nursery;
        private readonly IReporter _statusReporter;


        public QueenTests()
        {
            _nursery = Substitute.For<INursery>();
            _statusReporter = Substitute.For<IReporter>();
            _queen = new Queen(_nursery, _statusReporter);
        }

        [Fact]
        public void should_create_new_ant_types()
        {
            _queen.CreateType("Warrior");

            _nursery.Received(1).CreateType("Warrior");
        }

        [Fact]
        public void should_get_all_ant_types()
        {
            _queen.GetAntTypes();

            _nursery.Received(1).GetAntTypes();
        }

        [Fact]
        public void should_incubate_eggs()
        {
            _queen.LayEggs(5, "Warrior");

            _nursery.Received(1).IncubateEggs(5, "Warrior");
        }

        [Fact]
        public void should_check_colony_status()
        {
            _queen.CheckAnthill();

            _statusReporter.Received(1).Report();
        }
    }
}
