using Cemetery.Core.Corpses.DTOs;
using Cemetery.Core.Corpses.Getters;
using Cemetery.Core.Factory;
using System.Collections.Generic;

namespace Cemetery.Core
{
    class Cemetery : ICemetery
    {
        private readonly ICorpseGetter _corpseGetter;

        public Cemetery(ICemeteryAbstractFactory factory)
        {
            _corpseGetter = factory.BuildCorpseGetter();
        }

        public IReadOnlyCollection<CorpsesDTO> GetCorpses()
        {
            return _corpseGetter.Get();
        }
    }
}
