using MediatR;
using Nursery.Core.Factory;
using Nursery.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace Nursery.Core.Eggs.Handlers
{
    class IncubationHandler : IRequestHandler<IncubationRequest>
    {
        private readonly IIncubatorFactory _incubatorFactory;

        public IncubationHandler(IIncubatorFactory incubatorFactory)
        {
            _incubatorFactory = incubatorFactory;
        }

        public async Task<Unit> Handle(IncubationRequest request, CancellationToken cancellationToken)
        {
            var incubator = _incubatorFactory.Build();

            await incubator.Incubate(request);

            return Unit.Value;
        }
    }
}
