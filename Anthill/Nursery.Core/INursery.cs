using Nursery.Core.AntTypes.DTOs;
using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core
{
    public interface INursery
    {
        void IncubateEggs(int quantity, string type);
        void CreateType(string type);
        IReadOnlyCollection<AntTypeDTO> GetAntTypes();
        IReadOnlyCollection<EggsDTO> GetEggs();
    }
}
