using Cemetery.Core.Corpses.DTOs;
using Cemetery.Core.Corpses.Getters;
using System.Collections.Generic;

namespace Cemetery.Core
{
    class Cemetery : ICemetery
    {
        private readonly ICorpseGetter _corpseGetter;

        public Cemetery(ICorpseGetter corpseGetter)
        {
            _corpseGetter = corpseGetter;
        }

        public IReadOnlyCollection<CorpsesDTO> GetCorpses()
        {
            return _corpseGetter.Get();
        }
    }
}
