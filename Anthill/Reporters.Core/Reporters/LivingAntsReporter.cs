using Colony.Core;
using System.Linq;

namespace Reporters.Core.Reporters
{
    internal class LivingAntsReporter : IReporter
    {
        private IColony _colony;

        public LivingAntsReporter(IColony colony)
        {
            _colony = colony;
        }

        public string Report()
        {
            var ants = _colony.GetAnts();

            return string.Join("; ", ants.Select(s => s.ToString()));
        }
    }
}
