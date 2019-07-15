using MediatR;
using Nursery.Requests;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Colony.Core.Handler
{
    class EggsHatchedHandler : IRequestHandler<EggHatchedRequest>
    {
        public async Task<Unit> Handle(EggHatchedRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"{request.Quantity} {request.Type} ants were born");

            return Unit.Value;
        }
    }
}
