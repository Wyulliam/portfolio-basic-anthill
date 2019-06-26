using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.Eggs.Getters
{
    interface IEggGetter
    {
        IReadOnlyCollection<EggsDTO> Get();
    }
}
