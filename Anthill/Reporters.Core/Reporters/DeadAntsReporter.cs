using Cemetery.Core;
using System.Linq;

namespace Reporters.Core.Reporters
{
    internal class DeadAntsReporter : IReporter
    {
        private ICemetery _cemeteryRepository;

        public DeadAntsReporter(ICemetery cemetery)
        {
            _cemeteryRepository = cemetery;
        }

        public string Report()
        {
            var corpses = _cemeteryRepository.GetCorpses();

            return string.Join("; ", corpses.Select(s => s.ToString()));
        }
    }
}
