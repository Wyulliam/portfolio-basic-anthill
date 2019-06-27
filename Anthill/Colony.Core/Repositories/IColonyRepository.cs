using Colony.Core.Ants.DTOs;
using System.Collections.Generic;

namespace Colony.Core.Repositories
{
    interface IColonyRepository
    {
        IReadOnlyCollection<AntsDTO> GetAnts();
    }
}
