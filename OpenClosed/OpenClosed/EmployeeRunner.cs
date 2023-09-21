using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.CalculatorBases;
using OpenClosed.Calculators;

namespace OpenClosed
{
    internal class EmployeeRunner
    {
        public void Run()
        {
            WorkSpecs employeeWorkSpecs = new()
            {
                Hours = 160
            };


            SalaryCalculatorBase calculator = new SeniorSalaryCalculator();

            

            int salary = calculator.CalculateSalary(employeeWorkSpecs);


            Console.WriteLine($"The employee earns {salary}");
        }
    }
}
