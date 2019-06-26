using System.Linq;

namespace Anthill.Core
{
    internal class LivingAntsReporter : IReporter
    {
        private IColonyRepository _repository;

        public LivingAntsReporter(IColonyRepository repository)
        {
            _repository = repository;
        }

        public string Report()
        {
            var ants = _repository.GetAnts();

            return string.Join("; ", ants.Select(s => s.ToString()));
        }
    }
}
