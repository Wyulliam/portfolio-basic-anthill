using System.Linq;

namespace Anthill.Core
{
    internal class DeadAntsReporter : IReporter
    {
        private ICemeteryRepository _cemeteryRepository;

        public DeadAntsReporter(ICemeteryRepository cemeteryRepository)
        {
            _cemeteryRepository = cemeteryRepository;
        }

        public string Report()
        {
            var corpses = _cemeteryRepository.GetCorpses();

            return string.Join("; ", corpses.Select(s => s.ToString()));
        }
    }
}
