using MediatR;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Core.Eggs.Requests;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Nursery.Core.Eggs.Incubator
{
    internal class DefaultIncubator : IIncubator
    {
        private readonly IEggGenerator _eggGenerator;
        private readonly IEggGetter _eggGetter;
        private readonly IMediator _mediator;

        public int SecondsToIncubate => 10;

        public DefaultIncubator(IEggGenerator eggGenerator, IEggGetter eggGetter, IMediator mediator)
        {
            _eggGenerator = eggGenerator;
            _eggGetter = eggGetter;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(IncubationRequest request, CancellationToken cancellationToken)
        {
            await Incubate(request);
            return Unit.Value;
        }

        private async Task Incubate(IncubationRequest eggs)
        {
            await Task.Run(() =>
            {
                var dueDate = DateTime.Now.AddSeconds(SecondsToIncubate);

                var eggsWaitingToHatch = true;
                while (eggsWaitingToHatch)
                {
                    if (DateTime.Now > dueDate)
                    {
                        _mediator.Send(new EggHatchedRequest(eggs.Type, eggs.Quantity));
                        eggsWaitingToHatch = false;
                    }

                    Thread.Sleep(1000);
                }
            });
        }

        public IReadOnlyCollection<EggsDTO> GetEggs()
        {
            return _eggGetter.Get();
        }
    }
}
