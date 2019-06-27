using Colony.Core.Ants.DTOs;
using System.Collections.Generic;

namespace Colony.Core
{
    public interface IColony
    {
        IReadOnlyCollection<AntsDTO> GetAnts();
    }
}
