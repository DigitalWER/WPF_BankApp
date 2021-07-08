using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBankCS.accountFiles;

namespace JBankCS
{
    public class User
    {
        private static int _userIdCounter = 0;

        private int _id;
        private string _firstName;
        private string _lastName;
        private int _phoneNumber;
        private string _email;
        private string _username;
        private string _password;
        private DefaultAccount _defaultAccount;
        private HashSet<Account> _accounts = new HashSet<Account>();
        private List<TransactionHistory> _transactionHistory = new List<TransactionHistory>();

        public List<TransactionHistory> GetTransactionHistory
        {
            get { return _transactionHistory; }
        }

        public HashSet<Account> Accounts
        {
            get { return _accounts; }
        }


        public string getFirstName()
        {
            return _firstName;
        }

        public string getLastName()
        {
            return _lastName;
        }

        public int getPhoneNumber()
        {
            return _phoneNumber;
        }

        public string getEmail()
        {
            return _email;
        }

        public string getUsername()
        {
            return _username;
        }

        public string getPassword()
        {
            return _password;
        }

        public int getId()
        {
            return _id;
        }

        public DefaultAccount GetAccount()
        {
            return _defaultAccount;
            ;
        }

        public void setFirstName(string firstName)
        {
            if (firstName == null)
            {
                return;
            }
            _firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            if (lastName == null)
            {
                return;
            }
            _lastName = lastName;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            if (int.TryParse(phoneNumber, out int number) && phoneNumber.Length == 9)
            {
                _phoneNumber = number;
            }
            else
            {
                return;
            }
        }

        public void setEmail(string newEmail)
        {
            if (newEmail == null)
            {
                return;
            }
            _email = newEmail;
        }

        public void setPassword(string password)
        {
            if (password == null)
            {
                return;
            }
            _password = password;
        }
        public User(string firstName, string lastName, int phoneNumber, string email, string username, string password)
        {
            _id = ++_userIdCounter;
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _email = email;
            _username = username;
            _password = password;
            _defaultAccount = new DefaultAccount();
        }

    }
}
