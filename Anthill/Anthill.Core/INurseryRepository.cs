using System.Collections.Generic;

namespace Anthill.Core
{
    interface INurseryRepository
    {
        IReadOnlyCollection<EggsDTO> GetEggs();
    }
}
