using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Repositories;
using System.Collections.Generic;

namespace Nursery.Core.Eggs.Getters
{
    class DefaultEggGetter : IEggGetter
    {
        private readonly IEggRepository _repository;

        public DefaultEggGetter(IEggRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyCollection<EggsDTO> Get()
        {
            return _repository.Get();
        }
    }
}