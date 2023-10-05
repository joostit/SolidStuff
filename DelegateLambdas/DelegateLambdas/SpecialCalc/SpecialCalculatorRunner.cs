using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{
    internal class SpecialCalculatorRunner
    {

        public void Run()
        {

            CalculationDelegate calculation = (a, b) => (int)Math.Pow(a, b);
            INumberPrinter printer = new SortedNumberTextPrinter();


            SpecialCalculator calculator = new(calculation, printer);


            calculator.Run();
            

        }

    }
}
