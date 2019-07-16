using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Repositories;
using System;

namespace Nursery.Core.Eggs.Generators
{
    class DefaultEggGenerator : IEggGenerator
    {
        private IEggRepository _repository;

        public DefaultEggGenerator(IEggRepository repository)
        {
            _repository = repository;
        }
        
        public void Generate(EggsDTO eggs)
        {
            _repository.Create(
                new Entities.Eggs(eggs.Type, eggs.Quantity));
        }
    }
}
