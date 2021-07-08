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
        private string accountName;
        private string mainCurrency;


        public double Funds
        {
            get { return funds; }
            set 
            {   
                if(value>0)
                    funds += value; 
            }
        }


        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public string MainCurrency
        {
            get { return mainCurrency; }
            set { mainCurrency = value; }
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
