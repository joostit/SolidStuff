using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class TranslatorRunner
    {
        internal void Run()
        {

            TranslatorFactory factory = new();
            ITranslator translator = factory.GetTranslator("fr");
            Console.WriteLine(translator["car"]);


        }
    }
}
