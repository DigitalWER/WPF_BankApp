using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBankCS
{
    public abstract class Account
    {
        private double funds = 0;

        public double Funds
        {
            get { return funds; }
            set 
            {   
                if(value>0)
                    funds += value; 
            }
        }

        public virtual bool Withdraw(double withdravenValue)
        {
            if (funds >= withdravenValue)
            {
                funds = funds - withdravenValue;
                return true;
            }
            else
                return false;
        }

        public virtual void Deposit(double depositValue)
        {
            if (depositValue>0)
            {
                funds += depositValue;
            }
        }

        public virtual void exchangeMoney(string fromCurrency, string toCurrency, double moneyValue)
        {

        }
        
    }
}
