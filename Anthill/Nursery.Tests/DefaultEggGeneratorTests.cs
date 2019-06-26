using NSubstitute;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Repositories.Internal;
using Xunit;

namespace Nursery.Tests
{
    public class DefaultEggGeneratorTests
    {
        private IEggGenerator _eggGenerator;
        private IEggRepository _repository;

        public DefaultEggGeneratorTests()
        {
            _repository = Substitute.For<IEggRepository>();
            _eggGenerator = new DefaultEggGenerator(_repository);
        }

        [Fact]
        public void should_generate_eggs()
        {
            _eggGenerator.Generate(5, "Warrior");

            _repository.Received(1).Create(Arg.Is<EggsDTO>(a => a.Quantity == 5 && a.Type == "Warrior"));
        }
    }
}
