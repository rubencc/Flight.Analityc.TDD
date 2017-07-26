namespace Analityc.Domain.Interfaces
{
    public interface IFlightAnalityc
    {
        Classification Classification { get; set; }
        ICompanyFlight Flight { get; set; }
        int DelayedTime { get; set; }
        bool LandedOnSite { get; set; }
    }
}
