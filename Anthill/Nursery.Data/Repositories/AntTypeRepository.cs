using System.Collections.Generic;
using System.Linq;
using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.AntTypes.Entities;
using Nursery.Core.Repositories;

namespace Nursery.Data.Repositories
{
    class AntTypeRepository : IAntTypeRepository
    {
        public void Create(AntType type)
        {
            using (var context = new NurseryContext())
            {
                context.AntTypes.Add(type);
                context.SaveChanges();
            }   
        }

        public IReadOnlyCollection<AntType> Get()
        {
            using (var context = new NurseryContext())
            {
                return context.AntTypes.ToList();
            }
        }
    }
}
