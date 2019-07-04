using Nursery.Core;
using System.Linq;

namespace Reporters.Core.Reporters.StatusReporters
{
    internal class EggsIncubatingReporter : StatusReporter
    {
        private INursery _nursery;

        public EggsIncubatingReporter(INursery nursery)
        {
            _nursery = nursery;
        }

        public override string Report()
        {
            var eggs = _nursery.GetEggs();

            var eggsReport =  string.Join("; ", eggs.Select(s => s.ToString()));

            if (string.IsNullOrWhiteSpace(eggsReport))
                eggsReport = "There are no eggs incubating";

            return $"Eggs Incubating: {eggsReport}";
        }
    }
}
