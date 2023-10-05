using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambdas.SpecialCalc
{
    internal class UserAbortException : Exception
    {

        public UserAbortException()
        {
            
        }

        public UserAbortException(string msg)
            : base(msg)
        {
            
        }

        public UserAbortException(string msg, Exception inner)
            : base(msg, inner)
        {
            
        }

    }
}
