using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class SameContinentStrategy : IAnalizerStrategy
    {

        private int offsetTime;
        public bool CanApply(IFlightResume resume)
        {
            if (resume.Origin.Country == Country.UE
                && resume.Destination.Country == Country.UE)
            {
                this.offsetTime = 45;
                return true;
            }

            return false;
        }

        public void Apply(IProcessingResult result)
        {
            if ((result.Resume.ArrivalTime - result.Resume.DepartureTime.AddMinutes(result.Resume.PlannedTime)).Minutes > this.offsetTime)
            {
                result.Points++;
            }
        }

        public int Order => 2;
    }
}
