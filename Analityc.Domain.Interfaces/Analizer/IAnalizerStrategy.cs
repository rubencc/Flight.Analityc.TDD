namespace Analityc.Domain.Interfaces
{
    public interface IAnalizerStrategy
    {
        bool CanApply(IFlightResume resume);
        void Apply(IProcessingResult result);
        int Order { get; }
    }
}
