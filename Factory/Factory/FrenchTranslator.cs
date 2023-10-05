using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class FrenchTranslator : ITranslator
    {

        private Dictionary<string, string> french = new()
        {
            { "car", "paturain" },
            { "slim", "omeletteDuFromage" },
            { "chair", "baguette" }
        };


        public string this[string english]
        {
            get
            {
                return french[english];
            }
        }


    }
}
