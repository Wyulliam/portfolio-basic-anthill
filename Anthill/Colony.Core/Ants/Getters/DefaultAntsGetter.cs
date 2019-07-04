using Colony.Core.Ants.DTOs;
using Colony.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

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
            var x = _repository.Get();
            return _repository.Get().Select(s => new AntsDTO(s.Type, s.Quantity)).ToList();
        }
    }
}
