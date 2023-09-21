using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Number
    {
        private readonly int _value;

        public int Value { get => _value; }

        public Number(int value)
        {
            this._value = value;
        }

        public bool DividableBy(int divider)
        {
            return (Value % divider == 0);
        }

    }
}
