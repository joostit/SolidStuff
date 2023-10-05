using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas
{


    public delegate int OperatorDelegate(int inputA, int inputB);


    internal class CalculatorApp
    {



        public void RunCalc()
        {
            int userInputA;
            int userInputB;
            int result;
            OperatorDelegate operation;

            Console.WriteLine("What operation do you want?");
            Console.WriteLine("(A)dd");
            Console.WriteLine("(S)ubtract");
            Console.WriteLine("(D)ivide");
            Console.WriteLine("(M)multiply");
            char opChoice = Console.ReadKey().KeyChar;

            userInputA = AskInput("Enter the first number");
            userInputB = AskInput("Enter the second number");

            switch (opChoice)
            {
                case 'a':
                case 'A':
                    operation = (a, b) => a + b;                
                    break;

                case 's':
                case 'S':
                    operation = (a, b) => a - b;
                    break;

                case 'm':
                case 'M':
                    operation = (a, b) => a * b;
                    break;

                case 'd':
                case 'D':
                    operation = (a, b) => a / b;
                    break;

                case 'p':
                case 'P':
                    operation = SecondDegreePolynomial;
                    break;

                default:
                    throw new NotSupportedException("Not supported!!");
            }

            result = operation.Invoke(userInputA, userInputB);
            Console.WriteLine($"The result is {result}");



            userInputA = AskInput("Enter the first number");
            userInputB = AskInput("Enter the second number");
            result = operation.Invoke(userInputA, userInputB);
            Console.WriteLine($"The result is {result}");


            userInputA = AskInput("Enter the first number");
            userInputB = AskInput("Enter the second number");
            result = operation.Invoke(userInputA, userInputB);
            Console.WriteLine($"The result is {result}");


        }


        public int SecondDegreePolynomial(int a, int b)
        {
            int x = 0, c = 1;
            return (int)(a * Math.Pow(x, 2) + b * x + c);
        }


        private int AskInput(string Question)
        {
            return 42;
        }


    }
}
