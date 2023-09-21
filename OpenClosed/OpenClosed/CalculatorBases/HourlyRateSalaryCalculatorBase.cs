using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.CalculatorBases
{

    /// <summary>
    /// 
    /// </summary>
    internal abstract class HourlyRateSalaryCalculatorBase : SalaryCalculatorBase
    {

        private readonly int hourlyRate;

        public HourlyRateSalaryCalculatorBase(int hourlyRate)
        {
            this.hourlyRate = hourlyRate;
        }

        public override int CalculateSalary(WorkSpecs specs)
        {
            return specs.Hours * hourlyRate;
        }

}
    }
