using Nursery.Core.Eggs.DTOs;
using Nursery.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nursery.Core.Eggs.Incubator
{
    interface IIncubator 
    {
        Task Incubate(IncubationRequest eggs);
        IReadOnlyCollection<EggsDTO> GetEggs();

        int SecondsToIncubate { get; }
    }
}
