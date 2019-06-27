using Cemetery.Core;
using System.Linq;

namespace Reporters.Core.Reporters.StatusReporters
{
    internal class DeadAntsReporter : StatusReporter
    {
        private ICemetery _cemeteryRepository;

        public DeadAntsReporter(ICemetery cemetery)
        {
            _cemeteryRepository = cemetery;
        }

        public override string Report()
        {
            var corpses = _cemeteryRepository.GetCorpses();

            return string.Join("; ", corpses.Select(s => s.ToString()));
        }
    }
}
