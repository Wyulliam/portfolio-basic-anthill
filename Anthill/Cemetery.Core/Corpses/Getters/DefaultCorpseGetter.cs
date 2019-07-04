using Cemetery.Core.Corpses.DTOs;
using Cemetery.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cemetery.Core.Corpses.Getters
{
    class DefaultCorpseGetter : ICorpseGetter
    {
        private readonly ICorpseRepository _repository;

        public DefaultCorpseGetter(ICorpseRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyCollection<CorpsesDTO> Get()
        {
            return _repository.Get().Select(s => new CorpsesDTO(s.Type, s.Quantity)).ToList();
        }
    }
}
