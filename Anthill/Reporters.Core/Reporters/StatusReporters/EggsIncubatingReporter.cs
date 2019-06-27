using Nursery.Core;
using System.Linq;

namespace Reporters.Core.Reporters.StatusReporters
{
    internal class EggsIncubatingReporter : StatusReporter
    {
        private INursery _nursery;

        public EggsIncubatingReporter(INursery nurseryRepository)
        {
            _nursery = nurseryRepository;
        }

        public override string Report()
        {
            var eggs = _nursery.GetEggs();

            return string.Join("; ", eggs.Select(s => s.ToString()));
        }
    }
}
