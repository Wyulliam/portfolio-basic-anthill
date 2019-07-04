using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.AntTypes.Entities;
using System.Collections.Generic;

namespace Nursery.Core.Repositories
{
    interface IAntTypeRepository
    {
        void Create(AntType type);
        IReadOnlyCollection<AntType> Get();
    }
}
