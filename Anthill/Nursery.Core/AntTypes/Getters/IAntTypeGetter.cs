using Nursery.Core.AntTypes.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.AntTypes.Getters
{
    interface IAntTypeGetter
    {
        IReadOnlyCollection<AntTypeDTO> Get();
    }
}
