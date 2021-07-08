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
     
        private Account _accountType;

        private double _amountOfMoney;

        private string currency;
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

        public Account AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
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
        public TransactionHistory(string operation, Account accountType, double amountOfMoney, string currency)
        {
            Date = DateTime.Now;
            Operation = operation;
            AccountType = accountType;
            AmountOfMoney = amountOfMoney;
            Currency = currency;
        }
        public TransactionHistory(DateTime date,string operation, Account accountType, double amountOfMoney, string currency)
        {
            Date = date;
            Operation = operation;
            AccountType = accountType;
            AmountOfMoney = amountOfMoney;
            Currency = currency;
        }
    }
}
