using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class BankFacade
    {


        /// <summary>
        /// Withdraws money
        /// </summary>
        /// <param name="iban"></param>
        /// <param name="pin"></param>
        /// <param name="amount"></param>
        /// <returns>The amount of money that has been withdrawn. Will be 0 when no withdraw could be made</returns>
        public int Withdraw(string iban, string pin, int amount)
        {
            AuthManager auth = new AuthManager();
            CustomerManager custMan = new CustomerManager();
            CreditManager credit = new CreditManager();

            if (!custMan.CanWithdraw(iban)) { return 0; }
            if (!custMan.IsAccountValid(iban)) { return 0; }

            if (!auth.Authenticate(iban, pin)) { return 0; }

            if(credit.GetCredit(iban) < amount) { return 0; }

            return credit.ChangeCredit(iban, -amount);

        }



    }
}
