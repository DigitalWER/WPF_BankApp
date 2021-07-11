using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBankCS
{
    public class TransactionHistory
    {
        private DateTime _date;

        private string _operation;
     
        private Account _accountName;

        private double _amountOfMoney;

        private string currency;

        //private int _userID;

        //public int UserID
        //{
        //    get { return _userID; }
        //    set { _userID = value; }
        //}

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }

        public Account AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }
        public double AmountOfMoney
        {
            get { return _amountOfMoney; }
            set { _amountOfMoney = value; }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public TransactionHistory(string operation, Account accountName, double amountOfMoney, string currency)
        {
            Date = DateTime.Now;
            Operation = operation;
            AccountName = accountName;
            AmountOfMoney = amountOfMoney;
            Currency = currency;
        }
        public TransactionHistory(DateTime date,string operation, Account accountName, double amountOfMoney, string currency)
        {
            Date = date;
            Operation = operation;
            AccountName = accountName;
            AmountOfMoney = amountOfMoney;
            Currency = currency;
        }
    }
}
