using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterProxy.Interfaces;

namespace AdapterProxy.Calculators
{
    internal class BritishCostCalculator : IImperialPricingCalculator
    {
        public double GetQuoteForproduct(int lengthYards)
        {
            return lengthYards * 12;
        }
    }
}
