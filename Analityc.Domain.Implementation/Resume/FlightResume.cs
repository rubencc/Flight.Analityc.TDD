using System;
using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class FlightResume : IFlightResume
    {
        public ICompanyFlight Flight { get; set; }
        public string Code { get; set; }
        public ILocation Origin { get; set; }
        public ILocation Destination { get; set; }
        public ILocation Landed { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int PlannedTime { get; set; }
        public bool OnAlarm { get; set; }
        public bool MedicalEmergency { get; set; }
        public bool FireInTheLandingTrack { get; set; }
    }
}
