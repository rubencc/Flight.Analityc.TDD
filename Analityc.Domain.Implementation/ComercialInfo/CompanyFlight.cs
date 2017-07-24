using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class CompanyFlight : ICompanyFlight
    {
        public string CompanyCode { get; set; }
        public string FlightCode { get; set; }
        public string InternationalCode { get; set; }
    }
}
