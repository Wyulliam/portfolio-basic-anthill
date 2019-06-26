using System.Collections.Generic;

namespace Anthill.Core
{
    interface IAntTypeGetter
    {
        IReadOnlyCollection<AntTypeDTO> Get();
    }
}
