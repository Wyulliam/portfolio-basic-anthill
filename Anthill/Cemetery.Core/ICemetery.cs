using Cemetery.Core.Corpses.DTOs;
using System.Collections.Generic;

namespace Cemetery.Core
{
    public interface ICemetery
    {
        IReadOnlyCollection<CorpsesDTO> GetCorpses();
    }
}
