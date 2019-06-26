using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core
{
    public interface INursery
    {
        void IncubateEggs(int quantity, string type);
        void CreateType(string type);
        void GetAntTypes();
        IReadOnlyCollection<EggsDTO> GetEggs();
    }
}
