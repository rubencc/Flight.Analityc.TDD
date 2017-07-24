namespace Analityc.Domain.Interfaces
{
    public interface ILocation
    {
        string AirportCode { get; set; }
        Country Country { get; set; }
    }
}
