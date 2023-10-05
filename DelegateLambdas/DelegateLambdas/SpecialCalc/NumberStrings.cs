using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{
    internal class NumberStrings
    {

        private Dictionary<char, string> texts = new()
        {
            { '-', "minus" },
            { '0', "zero" },
            { '1', "one" },
            { '2', "two" },
            { '3', "three" },
            { '4', "four" },
            { '5', "five" },
            { '6', "six" },
            { '7', "seven" },
            { '8', "eight" },
            { '9', "nine" },
        };


        public string this[char num]
        {
            get
            {
                return texts[num];
            }
        }

    }
}
