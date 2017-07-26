using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class NotDestinationLandedStrategy : IAnalizerStrategy
    {
        public bool CanApply(IFlightResume resume)
        {
            return resume.Landed.AirportCode != resume.Destination.AirportCode;
        }

        public void Apply(IProcessingResult result)
        {
            result.Points += 4;
            result.Continue = false;
        }

        public int Order => 0;
    }
}
