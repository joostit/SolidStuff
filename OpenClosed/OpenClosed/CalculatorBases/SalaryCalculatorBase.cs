using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.CalculatorBases
{
    internal abstract class SalaryCalculatorBase
    {


        /// <summary>
        /// Calculates the salary
        /// </summary>
        /// <param name="specs">The workspecs for the salary to be calculated</param>
        /// <returns>The salary in euros</returns>
        public abstract int CalculateSalary(WorkSpecs specs);

        protected double CalculateTaxes()
        {
            return 123;
        }

    }
}
