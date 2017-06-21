namespace Analityc.Domain.Interfaces
{
    public class ICompanyFlight
    {
        string CompanyCode { get; set; }
        string FlightCode { get; set; }
        string InternationalCode { get; }
    }
}
