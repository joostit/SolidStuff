using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.CalculatorBases;

namespace OpenClosed.Calculators
{
    internal class SeniorSalaryCalculator : HourlyRateSalaryCalculatorBase
    {

        private const int hourlyRate = 30;

        public SeniorSalaryCalculator()
            : base(hourlyRate)
        {

        }

    }
}
