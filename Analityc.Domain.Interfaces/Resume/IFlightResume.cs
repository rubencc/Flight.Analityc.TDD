using System;

namespace Analityc.Domain.Interfaces
{
    public interface IFlightResume
    {
        ICompanyFlight CompanyCode { get; set; }
        string Code { get; set; }
        string Origin { get; set; }
        string Destination { get; set; }
        DateTime DepartureTime { get; set; }
        DateTime ArrivalTime { get; set; }
        int PlannedTime { get; set; }
        IFlightRating Rating { get; set; }
    }
}
