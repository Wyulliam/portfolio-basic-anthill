using System.Collections.Generic;

namespace Anthill.Core
{
    interface ICemeteryRepository
    {
        IReadOnlyCollection<CorpsesDTO> GetCorpses();
    }
}
