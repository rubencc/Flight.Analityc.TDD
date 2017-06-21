using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analityc.Domain.Interfaces
{
    public interface IFlightRating
    {
        double Rating { get; set; }
        Classification Clasification { get; set; }
    }
}
