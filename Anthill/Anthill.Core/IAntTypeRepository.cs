using System.Collections.Generic;

namespace Anthill.Core
{
    interface IAntTypeRepository
    {
        void Create(AntTypeDTO type);
        IReadOnlyCollection<AntTypeDTO> Get();
    }
}
