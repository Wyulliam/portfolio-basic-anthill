using Colony.Core.Ants.DTOs;
using System.Collections.Generic;

namespace Colony.Core.Ants.Getters
{
    interface IAntsGetter
    {
        IReadOnlyCollection<AntsDTO> Get();
    }
}
