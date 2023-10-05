using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{
    internal class PlainNumberPrinter : INumberPrinter
    {

        public void Print(int number)
        {
            Console.WriteLine($"The result is: {number}");
        }

    }
}
