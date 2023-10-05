using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{
    internal class SortedNumberTextPrinter : INumberPrinter
    {


        public void Print(int number)
        {
            List<string> numberTexts;
            string integerString;
            Console.WriteLine($"\nSorting '{number}':");

            integerString = number.ToString();
            numberTexts = GetAsNumberTexts(integerString);
            numberTexts.Sort(NumberTextComparers.ByLengthByAlphabet);       // Using the strategy pattern to define how to sort
            PrintNumberTexts(numberTexts);

            Console.WriteLine();
        }


        private List<string> GetAsNumberTexts(string txt)
        {
            List<string> retVal = new();
            NumberStrings strings = new();

            foreach(char num in txt)
            {
                string word = strings[num];
                retVal.Add(word);
            }

            return retVal;
        }


        private void PrintNumberTexts(List<string> numberTexts)
        {
            foreach (string number in numberTexts)
            {
                Console.WriteLine(number);
            }
        }


    }
}
