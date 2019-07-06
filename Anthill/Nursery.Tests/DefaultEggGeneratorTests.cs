using NSubstitute;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Entities;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Repositories;
using System;
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
            var dueDate = DateTime.Now;

            _eggGenerator.Generate(new EggsDTO("Warrior", 5), dueDate);

            _repository.Received(1).Create(Arg.Is<Eggs>(a => a.Quantity == 5 && a.Type == "Warrior" && a.GeneratedDate == dueDate));
        }
    }
}
