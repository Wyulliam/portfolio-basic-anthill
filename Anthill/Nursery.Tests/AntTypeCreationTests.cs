using NSubstitute;
using Nursery.Core.AntTypes.Creators;
using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.Repositories;
using Xunit;

namespace Nursery.Tests
{
    public class AntTypeCreationTests
    {
        private IAntTypeCreator _creator;
        private IAntTypeRepository _repository;

        public AntTypeCreationTests()
        {
            _repository = Substitute.For<IAntTypeRepository>();
            _creator = new DefaultAntTypeCreator(_repository);
        }

        [Fact]
        public void should_create_new_type_of_ants()
        {
            _creator.Create("Warrior");

            _repository.Received(1).Create(Arg.Is<AntTypeDTO>(a => a.Type == "Warrior"));
        } 
    }
}
