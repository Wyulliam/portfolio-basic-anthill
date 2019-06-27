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
            throw new NotImplementedException();
        }
    }
}
