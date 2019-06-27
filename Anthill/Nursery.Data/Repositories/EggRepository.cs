using System.Collections.Generic;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Repositories;

namespace Nursery.Data.Repositories
{
    class EggRepository : IEggRepository
    {
        public void Create(EggsDTO eggs)
        {
            
        }

        public IReadOnlyCollection<EggsDTO> Get()
        {
            return new List<EggsDTO>()
            {
                new EggsDTO(7, "Warrior"),
                new EggsDTO(4, "Workers")
            };
        }
    }
}
