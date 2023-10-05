using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class DutchTranslator : ITranslator
    {

        private Dictionary<string, string> dutch = new()
        {
            { "car", "auto" },
            { "slim", "dun" },
            { "chair", "stoel" }
        };


        public string this[string english]
        {
            get
            {
                return dutch[english];
            }
        }
    }
}
