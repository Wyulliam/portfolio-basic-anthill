using Cemetery.Core;
using Colony.Core;
using Nursery.Core;
using Reporters.Core.Reporters.AnthillStatusReporter;
using Reporters.Core.Reporters.StatusReporters;

namespace Reporters.Core.Factory
{
    class ReporterAbstractFactory : IReporterAbstractFactory
    {
        private readonly ICemetery _cemetery;
        private readonly INursery _nursery;
        private readonly IColony _colony;

        public ReporterAbstractFactory(ICemetery cemetery, INursery nursery, IColony colony)
        {
            _cemetery = cemetery;
            _nursery = nursery;
            _colony = colony;
        }

        public IAnthillStatusReporter BuildStatusReporter()
        {
            var deadAntsReporter = new DeadAntsReporter(_cemetery);
            var eggsIncubatingReporter = new EggsIncubatingReporter(_nursery);
            var livingAntsReporter = new LivingAntsReporter(_colony);

            return new DefaultAnthillStatusReporter(deadAntsReporter);
        }
    }
}
