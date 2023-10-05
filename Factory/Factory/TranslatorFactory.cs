using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class TranslatorFactory
    {

        public ITranslator GetTranslator(string language)
        {
            switch (language.ToLower())
            {
                case "nl":
                    return new DutchTranslator();

                case "fr":
                    return new FrenchTranslator();

                default:
                    throw new NotSupportedException($"{language} is not supported");
            }
        }

    }
}
