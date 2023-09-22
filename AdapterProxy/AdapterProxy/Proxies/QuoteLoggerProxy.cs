using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterProxy.Interfaces;

namespace AdapterProxy.Proxies
{
    internal class QuoteLoggerProxy : IEuroPricingCalculator
    {

        private readonly IEuroPricingCalculator target;

        public QuoteLoggerProxy(IEuroPricingCalculator target)
        {
            this.target = target;
        }


        public double GetPrice(double length)
        {
            double price = target.GetPrice(length);

            Console.WriteLine($"Logged a quote for {length}m. Cost: {Math.Round(price, 2)}");
            return price;
        }
    }
}
