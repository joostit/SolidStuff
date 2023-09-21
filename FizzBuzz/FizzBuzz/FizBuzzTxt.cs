using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizBuzzTxt
    {

        public string Locale { get; set; }

        Dictionary<FizzBuzzStates, string> Dutch = new() { };

        Dictionary<FizzBuzzStates, string> English = new() { };

        Dictionary<FizzBuzzStates, string> German = new() { };

        public string GetText(FizzBuzzStates state)
        {

            return Dutch[state];
        }


    }
}
