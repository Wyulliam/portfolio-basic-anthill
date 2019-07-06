using MediatR;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Requests;
using System.Collections.Generic;

namespace Nursery.Core.Eggs.Incubator
{
    interface IIncubator : IRequestHandler<IncubationRequest>
    {
        IReadOnlyCollection<EggsDTO> GetEggs();

        int SecondsToIncubate { get; }
    }
}
