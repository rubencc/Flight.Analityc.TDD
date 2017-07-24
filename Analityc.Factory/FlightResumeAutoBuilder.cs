using System;
using System.Linq;
using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class FlightResumeAutoBuilder : FlightResumeBuilder
    {
        private readonly Random random;

        public FlightResumeAutoBuilder(FlightResume resume) : base(resume)
        {
            this.random = new Random();
        }

        public FlightResumeBuilder WithAutoproperties()
        {

            if (this.Resume.Origin == null)
            {
                this.Resume.Origin = new Location()
                {
                    AirportCode = this.RandomString(3),
                    Country = this.RandomCountry()
                };
            }

            if (this.Resume.Destination == null)
            {
                this.Resume.Destination = new Location()
                {
                    AirportCode = this.RandomString(3),
                    Country = this.RandomCountry()
                };
            }

            if (this.Resume.Landed == null)
            {
                this.Resume.Landed = new Location()
                {
                    AirportCode = this.RandomString(3),
                    Country = this.RandomCountry()
                };
            }

            if (this.Resume.DepartureTime == new DateTime())
            {
                this.Resume.DepartureTime = DateTime.UtcNow.AddHours(-1);
            }

            if (this.Resume.ArrivalTime == new DateTime())
            {
                this.Resume.ArrivalTime = DateTime.UtcNow.AddHours(1);
            }

            if (this.Resume.PlannedTime == 0)
            {
                this.Resume.PlannedTime = this.random.Next(1,900);
            }

            return this;
        }

        
        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[this.random.Next(s.Length)]).ToArray());
        }

        private Country RandomCountry()
        {
            Array values = Enum.GetValues(typeof(Country));
            Country country = (Country)values.GetValue(this.random.Next(values.Length));

            return country;
        }

    }
}
