using Colony.Core.Ants.DTOs;
using System.Collections.Generic;

namespace Colony.Core.Repositories
{
    interface IAntsRepository
    {
        IReadOnlyCollection<Ants.Entities.Ants> Get();
    }
}
