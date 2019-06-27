using Cemetery.Core.Corpses.DTOs;
using System.Collections.Generic;

namespace Cemetery.Core.Corpses.Getters
{
    interface ICorpseGetter
    {
        IReadOnlyCollection<CorpsesDTO> Get();
    }
}
