namespace Analityc.Domain.Interfaces
{
    public interface IProcessingResult
    {
        IFlightResume Resume { get; set; }
        int Points { get; set; }
        bool Continue { get; set; }
    }
}
