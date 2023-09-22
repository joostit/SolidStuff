using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterProxy.Interfaces;

namespace AdapterProxy.Calculators
{
    internal class GermanRailsCalculator : IEuroPricingCalculator
    {
        public double GetPrice(double length)
        {
            return length * 24;
        }
    }
}
