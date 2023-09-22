using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class CustomerManager
    {


        public bool IsAccountValid(string iban)
        {
            return true;
        }


        public bool CanWithdraw(string iban)
        {
            return true;
        }


    }
}
