using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzRunner
    {

        public void Run()
        {
            List<FizzBuzzNumber> numbers = GetNumberSequence(1, 100);
            PrintFizzBuzzResult(numbers);
        }


        private List<FizzBuzzNumber> GetNumberSequence(int first, int last)
        {
            List<FizzBuzzNumber> retVal = new();

            for(int i = first; i <= last; i++)
            {
                FizzBuzzNumber num = new FizzBuzzNumber(i);
                retVal.Add(num);
            }

            return retVal;
        }



        private void PrintFizzBuzzResult(List<FizzBuzzNumber> numbers)
        {
            Output writer = new Output();

            foreach (var number in numbers)
            {
                string txt = GetNumberString(number);
                writer.Write(txt);
            }

        }



        private string GetNumberString(FizzBuzzNumber number)
        {

            switch (number.State)
            {
                case FizzBuzzStates.Plain:
                    return number.Value.ToString();
                case FizzBuzzStates.Fizz:
                    return "Fizz";
                case FizzBuzzStates.Buzz:
                    return "Buzz";
                case FizzBuzzStates.FizzBuzz:
                    return "FizzBuzz";
                default:
                    throw new NotSupportedException("Bug!");
            }
            
        }


    }
}
