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
            Funds = 100;
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
