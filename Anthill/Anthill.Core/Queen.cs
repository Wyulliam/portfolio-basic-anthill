using Nursery.Core;
using Reporters.Core;

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

        public void LayEggs(int quantity, string type)
        {
            _nursery.IncubateEggs(quantity, type);
        }

        public void CheckColony()
        {
            _statusReporter.Report();
        }

        public void CreateType(string type)
        {
            _nursery.CreateType(type);
        }

        public void GetAntTypes()
        {
            _nursery.GetAntTypes();
        }
    }
}
