using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProxy.Interfaces
{
    internal interface IImperialPricingCalculator
    {
        /// <summary>
        /// Gets a quote for the product
        /// </summary>
        /// <param name="lengthYards">The length in yards</param>
        /// <returns>The price in pounds</returns>
        double GetQuoteForproduct(int lengthYards);
    }
}
