using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.Repositories
{
    interface INurseryRepository
    {
        IReadOnlyCollection<EggsDTO> GetEggs();
    }
}
