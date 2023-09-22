using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterProxy.Interfaces;

namespace AdapterProxy.Adapters
{
    internal class ImperialPriceAdapter : IEuroPricingCalculator
    {

        private readonly IImperialPricingCalculator imperialCalculator;

        public ImperialPriceAdapter(IImperialPricingCalculator imperialCalculator)
        {
            this.imperialCalculator = imperialCalculator;
        }


        public double GetPrice(double length)
        {
            int yards = (int)Math.Ceiling(length / 0.914);
            Console.WriteLine($"Imperial Price Adapter: Converted length into {yards} yards.");
            double pounds = imperialCalculator.GetQuoteForproduct(yards);
            double euros = pounds / 0.87;
            Console.WriteLine($"Imperial Price Adapter: Converted price from {pounds} pounds.");
            return euros;
        }
    }
}
