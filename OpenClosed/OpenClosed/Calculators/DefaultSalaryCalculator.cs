using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.CalculatorBases;

namespace OpenClosed.Calculators
{
    internal class DefaultSalaryCalculator : HourlyRateSalaryCalculatorBase
    {

        private const int hourlyRate = 20;

        public DefaultSalaryCalculator()
            : base(hourlyRate)
        {

        }

    }
}
