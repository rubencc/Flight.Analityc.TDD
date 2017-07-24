using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class FlightResumeFactory
    {
        public FlightResumeBuilder Build(string code, string internationalCode, string companyCode)
        {
            ICompanyFlight companyFlight =
                new CompanyFlight()
                {
                    CompanyCode = companyCode,
                    FlightCode = code,
                    InternationalCode = internationalCode
                };

            return  new FlightResumeBuilder(new FlightResume(){Flight = companyFlight, Code = companyFlight.FlightCode});
        }

        public FlightResumeBuilder Build(ICompanyFlight companyFlight)
        {
            return new FlightResumeBuilder(new FlightResume() { Flight = companyFlight, Code = companyFlight.FlightCode });
        }
    }
}
