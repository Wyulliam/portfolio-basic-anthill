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
            return new List<AntsDTO>()
            {
                new AntsDTO(7, "Warrior"),
                new AntsDTO(4, "Workers")
            };
        }
    }
}
