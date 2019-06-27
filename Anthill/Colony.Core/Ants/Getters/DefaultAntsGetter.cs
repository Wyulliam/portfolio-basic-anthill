using Colony.Core.Ants.DTOs;
using Colony.Core.Repositories;
using System.Collections.Generic;

namespace Colony.Core.Ants.Getters
{
    class DefaultAntsGetter : IAntsGetter
    {
        private readonly IAntsRepository _repository;

        public DefaultAntsGetter(IAntsRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyCollection<AntsDTO> Get()
        {
            return _repository.Get();
        }
    }
}
