using Analityc.Domain.Interfaces;
using Analityc.Domain.Interfaces.Analitycs;

namespace Analityc.Domain.Implementation
{
    public class FlightAnalityc: IFlightAnalityc

    {
        public Classification Classification { get; set; }
        public ICompanyFlight Flight { get; set; }
        public int DelayedTime { get; set; }
        public bool LandedOnSite { get; set; }
    }
}
