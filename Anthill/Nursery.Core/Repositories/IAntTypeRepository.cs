using Nursery.Core.AntTypes.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.Repositories
{
    interface IAntTypeRepository
    {
        void Create(AntTypeDTO type);
        IReadOnlyCollection<AntTypeDTO> Get();
    }
}
