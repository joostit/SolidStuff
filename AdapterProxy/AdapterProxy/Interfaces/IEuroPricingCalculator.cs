using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProxy.Interfaces
{
    internal interface IEuroPricingCalculator
    {
        /// <summary>
        /// Gets the price of a product for a given length
        /// </summary>
        /// <param name="length">The length in Meters</param>
        /// <returns>The price in Euros</returns>
        double GetPrice(double length);
    }
}
