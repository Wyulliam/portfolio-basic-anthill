using Nursery.Core;
using Reporters.Core;
using System.Collections.Generic;
using System.Linq;

namespace Anthill.Core
{
    class Queen : IQueen
    {
        private INursery _nursery;
        private IReporter _statusReporter;

        public Queen(
            INursery nursery, 
            IReporter statusReporter)
        {
            _statusReporter = statusReporter;
            _nursery = nursery;
        }

        public string LayEggs(int quantity, string type)
        {
            _nursery.IncubateEggs(quantity, type);

            return $"Layed {quantity} {type} ant eggs";
        }

        public string CheckAnthill()
        {
            return _statusReporter.Report();
        }

        public string CreateType(string type)
        {
            _nursery.CreateType(type);

            return $"{type} type created";
        }

        public IReadOnlyCollection<string> GetAntTypes()
        {
            return _nursery.GetAntTypes().Select(s => s.Type).ToList();
        }
    }
}
