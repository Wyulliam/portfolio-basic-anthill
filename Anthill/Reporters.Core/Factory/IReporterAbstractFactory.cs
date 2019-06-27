using Reporters.Core.Reporters.AnthillStatusReporter;

namespace Reporters.Core.Factory
{
    interface IReporterAbstractFactory
    {
        IAnthillStatusReporter BuildStatusReporter();
    }
}
