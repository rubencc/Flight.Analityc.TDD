using System;

namespace Analityc.Domain.Interfaces
{
    public interface IFlightResume
    {
        ICompanyFlight Flight { get; set; }
        string Code { get; set; }
        ILocation Origin { get; set; }
        ILocation Destination { get; set; }
        ILocation Landed { get; set; }
        DateTime DepartureTime { get; set; }
        DateTime ArrivalTime { get; set; }
        int PlannedTime { get; set; }
        bool OnAlarm { get; set; }
        bool MedicalEmergency { get; set; }
        bool FireInTheLandingTrack { get; set; }
    }
}
