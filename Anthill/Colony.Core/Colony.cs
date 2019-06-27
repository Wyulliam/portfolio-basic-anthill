using Colony.Core.Ants.DTOs;
using Colony.Core.Ants.Getters;
using System.Collections.Generic;

namespace Colony.Core
{
    class Colony : IColony
    {
        private readonly IAntsGetter _antsGetter;

        public Colony(IAntsGetter antsGetter)
        {
            _antsGetter = antsGetter;
        }

        public IReadOnlyCollection<AntsDTO> GetAnts()
        {
            return _antsGetter.Get();
        }
    }
}
