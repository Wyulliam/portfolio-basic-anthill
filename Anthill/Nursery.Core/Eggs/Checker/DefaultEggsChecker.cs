using Nursery.Core.Eggs.DTOs;
using Nursery.Core.Eggs.Incubator;
using Nursery.Core.Factory;
using System.Collections.Generic;

namespace Nursery.Core.Eggs.Checker
{
    class DefaultEggsChecker : IEggsChecker
    {
        private readonly IIncubator _incubator;

        public DefaultEggsChecker(IIncubatorFactory incubatorFactory)
        {
            _incubator = incubatorFactory.Build();
        }

        public IReadOnlyCollection<EggsDTO> CheckEggs()
        {
            return _incubator.GetEggs();
        }
    }
}
