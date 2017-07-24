using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public static class FlightResumeFactory
    {
        public static FlightResumeAutoBuilder Build(string flightCode, string internationalCode, string companyCode)
        {
            ICompanyFlight companyFlight =
                new CompanyFlight()
                {
                    CompanyCode = companyCode,
                    FlightCode = flightCode,
                    InternationalCode = internationalCode
                };

            return  new FlightResumeAutoBuilder(new FlightResume(){Flight = companyFlight, Code = companyFlight.FlightCode});
        }

        public static FlightResumeAutoBuilder Build(ICompanyFlight companyFlight)
        {
            return new FlightResumeAutoBuilder(new FlightResume() { Flight = companyFlight, Code = companyFlight.FlightCode });
        }
    }
}
