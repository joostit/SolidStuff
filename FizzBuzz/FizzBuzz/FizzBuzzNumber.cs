using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz
{
    internal class FizzBuzzNumber : Number
    {


        private const int FizzValue = 3;
        private const int BuzzValue = 5;

        public FizzBuzzNumber(int value) 
            : base(value)
        {
        }

        public bool IsFizz
        {
            get
            {
                return DividableBy(FizzValue) && !DividableBy(BuzzValue);
            }
        }

        public bool IsBuzz
        {
            get
            {
                return !DividableBy(FizzValue) && DividableBy(BuzzValue);
            }
        }

        public bool IsFizzBuzz
        {
            get
            {
                return DividableBy(FizzValue) && DividableBy(BuzzValue);
            }
        }

        public bool IsPlainNumber
        {
            get
            {
                return !DividableBy(FizzValue) && !DividableBy(BuzzValue);
            }
        }

        public FizzBuzzStates State
        {
            get
            {
                if (IsPlainNumber) { return FizzBuzzStates.Plain; }
                if (IsFizz) { return FizzBuzzStates.Fizz; }
                if (IsBuzz) { return FizzBuzzStates.Buzz; }
                if (IsFizzBuzz) { return FizzBuzzStates.FizzBuzz; }

                throw new NotSupportedException("Bug!");
            }
        }
    }
}
