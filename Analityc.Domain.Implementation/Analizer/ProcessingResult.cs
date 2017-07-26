using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class ProcessingResult : IProcessingResult
    {
        public IFlightResume Resume { get; set; }
        public int Points { get; set; }
        public bool Continue { get; set; }
    }
}
