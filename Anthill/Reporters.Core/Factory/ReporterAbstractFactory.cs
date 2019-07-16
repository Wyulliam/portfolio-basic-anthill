using Cemetery.Core;
using Colony.Core;
using Nursery.Core.Eggs.Checker.Factory;
using Reporters.Core.Reporters.AnthillStatusReporter;
using Reporters.Core.Reporters.StatusReporters;

namespace Reporters.Core.Factory
{
    class ReporterAbstractFactory : IReporterAbstractFactory
    {
        private readonly ICemetery _cemetery;
        private readonly IEggsCheckerFactory _eggsCheckerFactory;
        private readonly IColony _colony;

        public ReporterAbstractFactory(ICemetery cemetery, IEggsCheckerFactory eggsCheckerFactory, IColony colony)
        {
            _cemetery = cemetery;
            _eggsCheckerFactory = eggsCheckerFactory;
            _colony = colony;
        }

        public IAnthillStatusReporter BuildStatusReporter()
        {
            var deadAntsReporter = new DeadAntsReporter(_cemetery);
            var eggsIncubatingReporter = new EggsIncubatingReporter(_eggsCheckerFactory);
            var livingAntsReporter = new LivingAntsReporter(_colony);

            return new DefaultAnthillStatusReporter(livingAntsReporter, eggsIncubatingReporter, deadAntsReporter);
        }
    }
}
