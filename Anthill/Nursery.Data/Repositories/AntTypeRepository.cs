using System.Collections.Generic;
using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.Repositories;

namespace Nursery.Data.Repositories
{
    class AntTypeRepository : IAntTypeRepository
    {
        public void Create(AntTypeDTO type)
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyCollection<AntTypeDTO> Get()
        {
            return new List<AntTypeDTO>()
            {
                new AntTypeDTO("Warrior"),
                new AntTypeDTO("Worker")
            };
        }
    }
}
