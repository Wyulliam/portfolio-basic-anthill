using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.Eggs.Generators
{
    interface IEggGetter
    {
        IReadOnlyCollection<EggsDTO> Get();
    }
}
