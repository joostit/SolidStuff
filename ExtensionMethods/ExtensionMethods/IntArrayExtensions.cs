using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntArrayExtensions
    {

        /// <summary>
        /// Blbalbla This method is not thread safe
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static long Product(this int[] self)
        {

            long product = 1;

            foreach (int val in self)
            {
                product *= val;
            }

            return product;
        }



        public static string WeekDayName(this int self)
        {
            switch (self)
            {
                case 0:
                    return "sunday";

                case 1:
                    return "monday";
                
                case 2:
                    return "tuesday";

                case 3:
                    return "wednessday";

                case 4:
                    return "thursday";

                case 5:
                    return "friday";

                case 6:
                    return "saturday";

                default:
                    throw new NotSupportedException($"{self} is not a weekday. Merely a weak day");
            }
        }


    }
}
