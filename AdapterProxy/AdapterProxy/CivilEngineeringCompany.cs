using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterProxy.Adapters;
using AdapterProxy.Calculators;
using AdapterProxy.Interfaces;
using AdapterProxy.Proxies;

namespace AdapterProxy
{
    internal class CivilEngineeringCompany
    {


        public void Run()
        {

            Console.WriteLine("Getting a direct quote for Dutch rails:");
            IEuroPricingCalculator dutchCalc = new DutchRailCalculator();
            double dutchPrice = dutchCalc.GetPrice(1000);
            Console.WriteLine($"Price: {dutchPrice}");
            Console.WriteLine();






            Console.WriteLine("Getting a quote for German rails through the logging proxy:");
            IEuroPricingCalculator germanCalc = new GermanRailsCalculator();
            germanCalc = new QuoteLoggerProxy(germanCalc);
            double germanPrice = germanCalc.GetPrice(1000);
            Console.WriteLine($"Price: {germanPrice}");
            Console.WriteLine();





            Console.WriteLine("Getting a quote for British rails through the imperial cost adapter");
            IImperialPricingCalculator britishPoundsCalc = new BritishCostCalculator();
            IEuroPricingCalculator britishCalc = new ImperialPriceAdapter(britishPoundsCalc);
            double britishPrice = britishCalc.GetPrice(1000);
            Console.WriteLine($"Price: {Math.Round(britishPrice, 2)}");
            Console.WriteLine();



            Console.WriteLine("Getting a quote for Scottish rails through both the imperial cost adapter and the logging proxy:");
            IImperialPricingCalculator scottishPoundsCalc = new ScottishCostCalculator();
            IEuroPricingCalculator scottishCalc = new ImperialPriceAdapter(scottishPoundsCalc);
            scottishCalc = new QuoteLoggerProxy(scottishCalc);
            double scottishPrice = scottishCalc.GetPrice(1000);
            Console.WriteLine($"Price: {Math.Round(scottishPrice, 2)}");
            Console.WriteLine();

            Console.ReadKey();
        }



    }
}
