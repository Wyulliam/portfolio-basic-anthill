using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.Repositories.Internal
{
    interface IEggRepository
    {
        void Create(EggsDTO eggs);
        IReadOnlyCollection<EggsDTO> Get();
    }
}
