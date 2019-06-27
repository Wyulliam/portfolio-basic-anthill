using Cemetery.Core.Corpses.DTOs;
using Cemetery.Core.Repositories;
using System.Collections.Generic;

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
            return _repository.Get();
        }
    }
}
