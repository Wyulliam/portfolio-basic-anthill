using MediatR;
using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Generators;
using Nursery.Core.Eggs.Getters;
using Nursery.Requests;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Nursery.Core.Eggs.Incubator
{
    internal abstract class Incubator : IIncubator
    {
        private readonly IEggGenerator _eggGenerator;
        private readonly IEggGetter _eggGetter;
        private readonly IMediator _mediator;

        public int SecondsToIncubate { get; }

        protected Incubator(IEggGenerator eggGenerator, 
            IEggGetter eggGetter, 
            IMediator mediator,
            int secondsToIncubate)
        {
            _eggGenerator = eggGenerator;
            _eggGetter = eggGetter;
            _mediator = mediator;

            SecondsToIncubate = secondsToIncubate;
        }

        public async Task Incubate(IncubationRequest eggs)
        {
            GenerateEggs(eggs);

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

        private void GenerateEggs(IncubationRequest eggs)
        {
            _eggGenerator.Generate(new EggsDTO(eggs.Type, eggs.Quantity));
        }

        public IReadOnlyCollection<EggsDTO> GetEggs()
        {
            return _eggGetter.Get();
        }
    }
}
