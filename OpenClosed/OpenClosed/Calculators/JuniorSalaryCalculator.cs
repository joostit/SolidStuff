using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.CalculatorBases;

namespace OpenClosed.Calculators
{
    internal class JuniorSalaryCalculator : SalaryCalculatorBase
    {
        public override int CalculateSalary(WorkSpecs specs)
        {
            return 100;
        }
    }
}
