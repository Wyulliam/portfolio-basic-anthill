using System.Linq;

namespace Anthill.Core
{
    internal class EggsIncubatingReporter : IReporter
    {
        private INurseryRepository _nurseryRepository;

        public EggsIncubatingReporter(INurseryRepository nurseryRepository)
        {
            _nurseryRepository = nurseryRepository;
        }

        public string Report()
        {
            var eggs = _nurseryRepository.GetEggs();

            return string.Join("; ", eggs.Select(s => s.ToString()));
        }
    }
}
