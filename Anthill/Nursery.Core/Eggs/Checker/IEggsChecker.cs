using Nursery.Core.Eggs.DTOs;
using System.Collections.Generic;

namespace Nursery.Core.Eggs.Checker
{
    public interface IEggsChecker
    {
        IReadOnlyCollection<EggsDTO> CheckEggs();
    }
}
