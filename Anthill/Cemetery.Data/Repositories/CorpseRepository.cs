using Cemetery.Core.Corpses.DTOs;
using Cemetery.Core.Repositories;
using System;
using System.Collections.Generic;

namespace Cemetery.Data.Repositories
{
    class CorpseRepository : ICorpseRepository
    {
        public IReadOnlyCollection<CorpsesDTO> Get()
        {
            return new List<CorpsesDTO>()
            {
                new CorpsesDTO(5, "Warrior"),
                new CorpsesDTO(12, "Workers")
            };
        }
    }
}
