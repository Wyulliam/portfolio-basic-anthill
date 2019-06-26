using Nursery.Core;
using System.Linq;

namespace Anthill.Core
{
    internal class EggsIncubatingReporter : IReporter
    {
        private INursery _nursery;

        public EggsIncubatingReporter(INursery nurseryRepository)
        {
            _nursery = nurseryRepository;
        }

        public string Report()
        {
            var eggs = _nursery.GetEggs();

            return string.Join("; ", eggs.Select(s => s.ToString()));
        }
    }
}
