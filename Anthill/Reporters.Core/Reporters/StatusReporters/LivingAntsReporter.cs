using Colony.Core;
using System.Linq;

namespace Reporters.Core.Reporters.StatusReporters
{
    internal class LivingAntsReporter : StatusReporter
    {
        private IColony _colony;

        public LivingAntsReporter(IColony colony)
        {
            _colony = colony;
        }

        public override string Report()
        {
            var ants = _colony.GetAnts();

            return string.Join("; ", ants.Select(s => s.ToString()));
        }
    }
}
