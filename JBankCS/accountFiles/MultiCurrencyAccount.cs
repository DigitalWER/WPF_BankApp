using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBankCS.accountFiles
{
    public class MultiCurrencyAccount : Account
    {
        public MultiCurrencyAccount(string name, string currency)
        {
            TransferFee = 0.00;
            GenerateAccNumber();
            AccountName = name;
            MainCurrency = currency;
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

        public override void Deposit(double depositValue, string currency)
        {
            if (depositValue > 0)
            {
                Funds += depositValue;
            }
        }

        public virtual void exchangeMoney(string fromCurrency, string toCurrency, double moneyValue)
        {

        }
    }

    
}
