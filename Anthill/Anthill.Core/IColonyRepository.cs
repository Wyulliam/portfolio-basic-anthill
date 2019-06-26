using System.Collections.Generic;

namespace Anthill.Core
{
    interface IColonyRepository
    {
        IReadOnlyCollection<AntsDTO> GetAnts();
    }
}
