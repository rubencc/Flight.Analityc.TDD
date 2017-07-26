using System.Collections.Generic;
using System.Linq;
using Analityc.Domain.Interfaces;

namespace Analityc.Domain.Implementation
{
    public class FlightValidator : IAnalizer
    {
        private readonly List<IAnalizerStrategy> strategies
            = new List<IAnalizerStrategy>() { new SameContinentStrategy(), new NotDestinationLandedStrategy() };


        public IFlightAnalityc Analize(IFlightResume resume)
        {

            var result = this.CreateProcessingResult(resume);

            foreach (var strategy in this.strategies.OrderBy(item => item.Order).Where(item => item.CanApply(resume)))
            {
                strategy.Apply(result);
                if (result.Continue == false)
                    break;
            }

            return new FlightAnalityc()
            {
                Classification = Classification.A - result.Points
            };
        }

        private IProcessingResult CreateProcessingResult(IFlightResume resume)
        {
            IProcessingResult result = new ProcessingResult()
            {
                Resume = resume,
                Points = 0,
                Continue = true
            };
            return result;
        }
    }
}
