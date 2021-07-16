using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBankCS
{
    public abstract class Account
    {
        private double _funds = 0;
        private string _accountName;
        private string _mainCurrency;

        private string _accountNumber;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }


        private double _transferFee = 0.01;

        public double TransferFee
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
            get { return _funds; }
            set 
            {   
                if(value>0)
                    _funds += value; 
            }
        }


        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        public string MainCurrency
        {
            get { return _mainCurrency; }
            set { _mainCurrency = value; }
        }



        public virtual bool Withdraw(double withdravenValue)
        {
            if (_funds >= withdravenValue)
            {
                _funds = _funds - withdravenValue;
                return true;
            }
            else
                return false;
        }

        public virtual void Deposit(double depositValue)
        {
            if (depositValue>0)
            {
                _funds += depositValue;
            }
        }

        public virtual void Deposit(double depositValue, string currency)
        {
            if (depositValue > 0)
            {
                if (currency.Equals(_mainCurrency) || currency.Equals("ALL"))
                    _funds += depositValue;
                else
                    _funds += depositValue - (depositValue * TransferFee);
            }
        }


        public override string ToString()
        {
            return _accountName;
        }

        public void GenerateAccNumber()
        {
            Random random = new Random();
            AccountNumber = random.Next(1000000, 9999999).ToString() + random.Next(1000000, 9999999).ToString() + random.Next(1000000, 9999999).ToString() + random.Next(1000000, 9999999).ToString();
        }
    }
}
