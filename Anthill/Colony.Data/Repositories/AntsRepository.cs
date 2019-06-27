using Colony.Core.Ants.DTOs;
using Colony.Core.Repositories;
using System;
using System.Collections.Generic;

namespace Colony.Data.Repositories
{
    class AntsRepository : IAntsRepository
    {
        public IReadOnlyCollection<AntsDTO> Get()
        {
            throw new NotImplementedException();
        }
    }
}
