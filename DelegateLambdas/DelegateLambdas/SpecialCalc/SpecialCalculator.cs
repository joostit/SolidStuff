using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{

    public delegate int CalculationDelegate(int inA, int inB);

    internal class SpecialCalculator
    {
        private readonly CalculationDelegate calculation;
        private readonly INumberPrinter printer;

        public SpecialCalculator(CalculationDelegate calculation, INumberPrinter printer)
        {
            this.calculation = calculation;
            this.printer = printer;
        }


        public void Run()
        {
            bool keepRunning = true;
            
            while (keepRunning)
            {
                try
                {
                    DoCalculation();
                }
                catch (UserAbortException)
                {
                    keepRunning = false;
                }
            }
        }


        private void DoCalculation()
        {
            int inA = AskInt("Enter the first number");
            int inB = AskInt("Enter the second number");
            int result = calculation.Invoke(inA, inB);
            printer.Print(result);
        }


        private int AskInt(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine() ?? "";

            try
            {
                return int.Parse(answer);
            }
            catch (FormatException)
            {
                throw new UserAbortException();
            }
        }


    }
}
