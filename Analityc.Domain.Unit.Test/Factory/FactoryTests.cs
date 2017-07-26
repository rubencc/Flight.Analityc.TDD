using System;
using Analityc.Domain.Implementation;
using Analityc.Domain.Interfaces;
using FluentAssertions;
using Xunit;


namespace Analityc.Domain.Unit.Test.Factory
{
    //[Trait("Factory", "Creacion")]
    //public class FactoryTests
    //{
    //    [Fact(DisplayName = "Crear un resumen con propiedades automaticas")]
    //    public void Crear_resumen_con_propiedades_automaticas()
    //    {
    //        DateTime date = DateTime.UtcNow;
    //        ;
    //        IFlightResume resume = FlightResumeFactory.Build("IB2730", "MAD-BCN-0730", "IB")
    //            .WithAutoproperties()
    //            .Create();


    //        resume.Flight.FlightCode.Should().Be("IB2730");
    //        resume.Flight.InternationalCode.Should().Be("MAD-BCN-0730");
    //        resume.Flight.CompanyCode.Should().Be("IB");
    //        resume.Code.Should().Be("IB2730");

    //        resume.DepartureTime.Should().NotBeBefore(date.AddHours(-1));
    //        resume.ArrivalTime.Should().NotBeBefore(date.AddHours(1));
    //        resume.PlannedTime.Should().BeInRange(1, 900);

    //        resume.Origin.Should().NotBeNull();
    //        resume.Destination.Should().NotBeNull();
    //        resume.Landed.Should().NotBeNull();

    //        resume.Origin.Country.Should().BeAssignableTo<Country>();
    //        resume.Origin.AirportCode.Should().NotBeNullOrEmpty();
    //        resume.Origin.AirportCode.Length.Should().Be(3);

    //        resume.Destination.Country.Should().BeAssignableTo<Country>();
    //        resume.Destination.AirportCode.Should().NotBeNullOrEmpty();
    //        resume.Destination.AirportCode.Length.Should().Be(3);

    //        resume.Landed.Country.Should().BeAssignableTo<Country>();
    //        resume.Landed.AirportCode.Should().NotBeNullOrEmpty();
    //        resume.Landed.AirportCode.Length.Should().Be(3);

    //    }
    //}
}
