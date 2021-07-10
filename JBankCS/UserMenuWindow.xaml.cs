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
    /// Logika interakcji dla klasy UserMenuWindow.xaml
    /// </summary>
    public partial class UserMenuWindow : Window
    {
        private User user;
        public UserMenuWindow(User user)
        {
            this.user = user;
            InitializeComponent();
            OperationBox.Items.Add("Deposit");
            OperationBox.Items.Add("Withdraw");
            OperationBox.SelectedIndex = 1;
            LabelName.Content = user.getFirstName();
            LastName.Content = user.getLastName();
            Email.Content = user.getEmail();
            Username.Content = user.getUsername();
            resetDataGrid();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (moneyAmountOperation.Text != "")
            {
                if (accountListDataGrid.SelectedItem != null)
                {
                    if ((string)OperationBox.SelectedItem == "Deposit")
                    {
                        Account selectedAccount = (Account)accountListDataGrid.SelectedItem;
                        selectedAccount.Deposit(double.Parse(moneyAmountOperation.Text));
                        user.GetTransactionHistory.Add(new TransactionHistory("Deposit", selectedAccount, double.Parse(moneyAmountOperation.Text), selectedAccount.MainCurrency));
                        MessageBox.Show("Deposit is completed");
                    }
                    else
                    {
                        Account selectedAccount = (Account)accountListDataGrid.SelectedItem;
                        if (!selectedAccount.Withdraw(double.Parse(moneyAmountOperation.Text)))
                        {
                            MessageBox.Show("Not enough money in the account to complete the operation");
                        }
                        else
                        {
                            user.GetTransactionHistory.Add(new TransactionHistory("Withdraw", selectedAccount, double.Parse(moneyAmountOperation.Text), selectedAccount.MainCurrency));
                            MessageBox.Show("Operation completed");
                        }
                    }
                    resetDataGrid();
                }
            }
        }

        private void logOutAndOpenStartWindow(object sender, RoutedEventArgs e)
        {
            StartWindowSignIn objOpenWindow = new StartWindowSignIn();
            this.Close();
            objOpenWindow.Show();
            MessageBox.Show("You have logged out successfully");
        }

        private void openCreateAccountWindow(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow objOpenWindow = new CreateAccountWindow(user);
            this.Close();
            objOpenWindow.Show();
        }

        private void openTransactionHistoryWindow(object sender, RoutedEventArgs e)
        {
            TransactionHistoryWindow objOpenWindow = new TransactionHistoryWindow(user);
            this.Close();
            objOpenWindow.Show();
        }

        private void resetDataGrid()
        {
            accountListDataGrid.ItemsSource = null;
            accountListDataGrid.ItemsSource = user.Accounts;
        }

       
    }
}
