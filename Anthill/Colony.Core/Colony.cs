using Colony.Core.Ants.DTOs;
using Colony.Core.Ants.Getters;
using Colony.Core.Factory;
using System.Collections.Generic;

namespace Colony.Core
{
    class Colony : IColony
    {
        private readonly IAntsGetter _antsGetter;

        public Colony(IColonyAbstractFactory factory)
        {
            _antsGetter = factory.BuildAntsGetter();
        }

        public IReadOnlyCollection<AntsDTO> GetAnts()
        {
            return _antsGetter.Get();
        }
    }
}
