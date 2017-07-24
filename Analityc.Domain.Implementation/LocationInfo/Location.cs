using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class Location : ILocation
    {
        public string AirportCode { get; set; }
        public Country Country { get; set; }
    }
}
