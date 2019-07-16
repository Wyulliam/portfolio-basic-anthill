using Nursery.Core;
using Nursery.Core.Eggs.Checker;
using Nursery.Core.Eggs.Checker.Factory;
using System.Linq;

namespace Reporters.Core.Reporters.StatusReporters
{
    internal class EggsIncubatingReporter : StatusReporter
    {
        private IEggsChecker _eggsChecker;

        public EggsIncubatingReporter(IEggsCheckerFactory eggsCheckerFactory)
        {
            _eggsChecker = eggsCheckerFactory.Build();
        }

        public override string Report()
        {
            var eggs = _eggsChecker.CheckEggs();

            var eggsReport =  string.Join("; ", eggs.Select(s => s.ToString()));

            if (string.IsNullOrWhiteSpace(eggsReport))
                eggsReport = "There are no eggs incubating";

            return $"Eggs Incubating: {eggsReport}";
        }
    }
}
