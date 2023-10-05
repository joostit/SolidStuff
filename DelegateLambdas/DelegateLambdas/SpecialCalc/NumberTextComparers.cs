using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{
    internal static class NumberTextComparers
    {

        public static Comparison<string> ByLengthByAlphabet
        {
            get =>
                (x, y) =>
                {
                    if (x == null || y == null) { throw new NotSupportedException("Cannot compare null values"); }

                    if (x.Length < y.Length) return -1;
                    if (x.Length > y.Length) return 1;

                    return String.Compare(x, y);
                };
        }


    }
}
