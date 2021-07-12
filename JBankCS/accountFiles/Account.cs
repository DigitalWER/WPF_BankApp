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

        private string _accountNumber;

        public string accountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }


        private double _transferFee = 0.01;

        public double transferFee
        {
            get { return _transferFee; }
            set { _transferFee = value; }
        }

        //We should add this field if we want later work on entity framework
        //private int _userID;

        //public int UserID
        //{
        //    get { return _userID; }
        //    set { _userID = value; }
        //}


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
        public override string ToString()
        {
            return accountName;
        }
    }
}
