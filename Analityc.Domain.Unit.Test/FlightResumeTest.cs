using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analityc.Domain.Implementation;
using Analityc.Domain.Interfaces;
using Analityc.Domain.Interfaces.Analitycs;
using FluentAssertions;
using Xunit;

namespace Analityc.Domain.Unit.Test
{
    public class FlightResumeTest
    {
        private FlightValidator validator;

        public FlightResumeTest()
        {
            this.validator = new FlightValidator();
        }


        [Fact(DisplayName = "Vuelo que no aterriza en destino")]
        public void Vuelo_que_no_aterriza_en_su_destino()
        {
            IFlightResume resume = FlightResumeFactory.Build("AZ100", "INTER", "VLZ")
                .WithAutoproperties()
                .WithLanded("MAD", Country.Spain)
                .WithDestination("BCN", Country.Spain)
                .Create();

            IFlightAnalityc result = this.validator.Analize(resume);

            result.Classification.Should().Be(Classification.E);
        }

        [Fact(DisplayName = "Vuelo con misma hora de llegada que estimada")]
        public void Vuelo_con_misma_hora_de_llegada_que_estimada()
        {
            DateTime date = DateTime.Now;
            

            IFlightResume resume = FlightResumeFactory.Build("AZ100", "INTER", "VLZ")
                .WithAutoproperties()
                .WithSameDestinationAndLanded("MAD", Country.Spain)
                .WithPlannedTime(55)
                .WithDepartureTime(date)
                .WithArrivalTime(date.AddMinutes(55))
                .Create();

            IFlightAnalityc result = this.validator.Analize(resume);

            result.Classification.Should().Be(Classification.APlus);
        }

        [Fact(DisplayName = "Vuelo con misma hora de llegada que estimada diferente lugar de aterrizaje")]
        public void Vuelo_con_misma_hora_de_llegada_que_estimada_diferente_lugar_de_aterrizaje()
        {
            DateTime date = DateTime.Now;


            IFlightResume resume = FlightResumeFactory.Build("AZ100", "INTER", "VLZ")
                .WithAutoproperties()
                .WithPlannedTime(55)
                .WithDepartureTime(date)
                .WithArrivalTime(date.AddMinutes(55))
                .Create();

            IFlightAnalityc result = this.validator.Analize(resume);

            result.Classification.Should().Be(Classification.E);
        }

        [Fact(DisplayName = "Vuelo dentro de la UE con retraso de 50min y aterrizaje en otro destino")]
        public void Vuelo_dentro_de_la_UE_con_retraso_de_50min_otro_destino()
        {
            DateTime date = DateTime.Now;

            IFlightResume resume = FlightResumeFactory.Build("AZ100", "INTER", "VLZ")
                .WithAutoproperties()
                .WithOrigin("LUT", Country.UE)
                .WithDestination("MAD", Country.UE)
                .WithLanded("BCN", Country.UE)
                .WithPlannedTime(55)
                .WithDepartureTime(date)
                .WithArrivalTime(date.AddMinutes(55 +50))
                .Create();

            IFlightAnalityc result = this.validator.Analize(resume);

            result.Classification.Should().Be(Classification.E);
        }

        [Fact(DisplayName = "Vuelo dentro de la UE con retraso de 20min")]
        public void Vuelo_dentro_de_la_UE_con_retraso_de_20min()
        {
            DateTime date = DateTime.Now;


            IFlightResume resume = FlightResumeFactory.Build("AZ100", "INTER", "VLZ")
                .WithAutoproperties()
                .WithOrigin("LUT", Country.UE)
                .WithSameDestinationAndLanded("MAD", Country.UE)
                .WithPlannedTime(55)
                .WithDepartureTime(date)
                .WithArrivalTime(date.AddMinutes(55+20))
                .Create();

            IFlightAnalityc result = this.validator.Analize(resume);

            result.Classification.Should().Be(Classification.A);
        }

        [Fact(DisplayName = "Vuelo dentro de la UE con retraso de 50min")]
        public void Vuelo_dentro_de_la_UE_con_retraso_de_250min()
        {
            DateTime date = DateTime.Now;


            IFlightResume resume = FlightResumeFactory.Build("AZ100", "INTER", "VLZ")
                .WithAutoproperties()
                .WithOrigin("LUT", Country.UE)
                .WithSameDestinationAndLanded("MAD", Country.UE)
                .WithPlannedTime(55)
                .WithDepartureTime(date)
                .WithArrivalTime(date.AddMinutes(55 + 50))
                .Create();

            IFlightAnalityc result = this.validator.Analize(resume);

            result.Classification.Should().Be(Classification.B);
        }
    }
}
