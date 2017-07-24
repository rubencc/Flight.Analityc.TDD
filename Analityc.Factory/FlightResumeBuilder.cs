using System;
using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class FlightResumeBuilder
    {
        protected readonly FlightResume Resume;

        public FlightResumeBuilder(FlightResume resume)
        {
            this.Resume = resume;
        }

        public FlightResumeBuilder WithOrigin(string airportCode, Country country)
        {
            this.Resume.Origin = new Location(){AirportCode = airportCode, Country = country};

            return this;
        }

        public FlightResumeBuilder WithOrigin(ILocation location)
        {
            this.Resume.Origin = location;

            return this;
        }

        public FlightResumeBuilder WithDestination(string airportCode, Country country)
        {
            this.Resume.Destination = new Location() { AirportCode = airportCode, Country = country };

            return this;
        }

        public FlightResumeBuilder WithDestination(ILocation location)
        {
            this.Resume.Destination = location;

            return this;
        }

        public FlightResumeBuilder WithLanded(string airportCode, Country country)
        {
            this.Resume.Landed = new Location() { AirportCode = airportCode, Country = country };

            return this;
        }

        public FlightResumeBuilder WithLanded(ILocation location)
        {
            this.Resume.Landed = location;

            return this;
        }

        public FlightResumeBuilder WithDepartureTime(DateTime time)
        {
            this.Resume.DepartureTime = time;

            return this;
        }

        public FlightResumeBuilder WithArrivalTime(DateTime time)
        {
            this.Resume.ArrivalTime = time;

            return this;
        }

        public FlightResumeBuilder WithPlannedTime(int time)
        {
            this.Resume.PlannedTime = time;

            return this;
        }

        public IFlightResume Create()
        {
            return this.Resume;
        }
    }
}
