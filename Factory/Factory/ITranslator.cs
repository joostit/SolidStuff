using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal interface ITranslator
    {
        string this[string english] { get; }
    }
}
