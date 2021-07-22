using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBankCS.accountFiles
{
    public class DefaultAccount : Account
    {
        
        public DefaultAccount()
        {
            GenerateAccNumber();
            AccountName = "defaultAccount";
            MainCurrency = null;
            Funds = 0;
        }

        public DefaultAccount(string name, string basicCurrency)
        {
            GenerateAccNumber();
            AccountName = name;
            MainCurrency = basicCurrency;
            Funds = 0;
        }


        public override bool Withdraw(double withdravenValue)
        {
            return base.Withdraw(withdravenValue);
        }

        public override void Deposit(double depositValue)
        {
            base.Deposit(depositValue);
        }
    }
}
