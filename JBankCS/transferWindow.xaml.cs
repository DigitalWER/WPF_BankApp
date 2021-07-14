using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JBankCS
{
    /// <summary>
    /// Interaction logic for transferWindow.xaml
    /// </summary>
    public partial class transferWindow : Window
    {
        private User _user;
        private Account _account;

        public transferWindow(User user, Account account)
        {
            _user = user;
            _account = account;
            InitializeComponent();
            accountName.Content = account.AccountName;
            accountNumber.Content = account.accountNumber;
            moneyAmount.Content = account.Funds;
            currency.Content = account.MainCurrency;
        }

        private void openMainWindow(object sender, RoutedEventArgs e)
        {
            UserMenuWindow objOpenWindow = new UserMenuWindow(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void transferMoney(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(moneyToTransfer.Text) || string.IsNullOrEmpty(accNumberToTransfer.Text))
            {
                MessageBox.Show("Inputs are incorrect or empty");
            }
            else
            {
                foreach (var account in _user.Accounts)
                {
                    if (account.accountNumber.Equals(accNumberToTransfer.Text))
                    {
                        //Change from maualy changing property to using build in class methods of withdraw and deposit.
                        account.Deposit(double.Parse(moneyToTransfer.Text));
                        //account.Funds += double.Parse(moneyToTransfer.Text);
                        _user.Accounts.Remove(_account);
                        _account.Withdraw(double.Parse(moneyToTransfer.Text));
                        //_account.Funds -= double.Parse(moneyToTransfer.Text);
                        //Should add line below to add new transaction history to account probobly if we finish entity framework this should be added to both users.
                        //_user.GetTransactionHistory.Add(new TransactionHistory("transfer on account", _account, double.Parse(moneyToTransfer.Text), _account.MainCurrency));
                        _user.Accounts.Add(_account);
                        break;
                    }
                }
                MessageBox.Show("Operation completed");
                openMainWindow(sender, e);
            }
        }
    }
}
