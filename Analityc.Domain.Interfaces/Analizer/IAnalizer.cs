using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analityc.Domain.Interfaces.Analitycs;

namespace Analityc.Domain.Interfaces
{
    public interface IAnalizer
    {
        IFlightAnalityc Analize(IFlightResume resume);
    }
}
