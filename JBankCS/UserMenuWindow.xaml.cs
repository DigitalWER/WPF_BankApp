using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace JBankCS
{
    /// <summary>
    /// Logika interakcji dla klasy UserMenuWindow.xaml
    /// </summary>
    public partial class UserMenuWindow : Window
    {
        private User _user;
        public UserMenuWindow(User user)
        {
            this._user = user;
            InitializeComponent();
            OperationBox.Items.Add("Deposit");
            OperationBox.Items.Add("Withdraw");
            OperationBox.SelectedIndex = 1;
            LabelName.Content = user.getFirstName();
            LastName.Content = user.getLastName();
            Email.Content = user.getEmail();
            Username.Content = user.getUsername();
            phoneNumber.Content = user.getPhoneNumber();
            resetDataGrid();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (moneyAmountOperation.Text != "" && double.TryParse(moneyAmountOperation.Text, out double moneyAmount) && moneyAmount > 0)
            {
                if (accountListDataGrid.SelectedItem != null)
                {
                    if ((string)OperationBox.SelectedItem == "Deposit")
                    {
                        Account selectedAccount = (Account)accountListDataGrid.SelectedItem;
                        selectedAccount.Deposit(moneyAmount);
                        _user.GetTransactionHistory.Add(new TransactionHistory("Deposit", selectedAccount, moneyAmount, selectedAccount.MainCurrency));
                        MessageBox.Show("Deposit is completed");
                    }
                    else
                    {
                        Account selectedAccount = (Account)accountListDataGrid.SelectedItem;
                        if (!selectedAccount.Withdraw(moneyAmount))
                        {
                            MessageBox.Show("Not enough money in the account to complete the operation");
                        }
                        else
                        {
                            _user.GetTransactionHistory.Add(new TransactionHistory("Withdraw", selectedAccount, moneyAmount, selectedAccount.MainCurrency));
                            MessageBox.Show("Operation completed");
                        }
                    }
                    resetDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
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
            CreateAccountWindow objOpenWindow = new CreateAccountWindow(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void openTransactionHistoryWindow(object sender, RoutedEventArgs e)
        {
            TransactionHistoryWindow objOpenWindow = new TransactionHistoryWindow(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void resetDataGrid()
        {
            accountListDataGrid.ItemsSource = null;
            accountListDataGrid.ItemsSource = _user.Accounts;
        }

        private void openTransferWindow(object sender, RoutedEventArgs e)
        {
            if (accountListDataGrid.SelectedItem != null)
            {
                transferWindow objOpenWindow = new transferWindow(_user, (Account)accountListDataGrid.SelectedItem);
                this.Close();
                objOpenWindow.Show();
            }
            else
            {
                MessageBox.Show("You need to choose an account before that operation");
            }
        }

        private void openChangeUserDataWindow(object sender, RoutedEventArgs e)
        {
            userOptions objOpenWindow = new userOptions(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var displayName = GetPropertyDisplayName(e.PropertyDescriptor);

            if (!string.IsNullOrEmpty(displayName))
            {
                e.Column.Header = displayName;
            }

        }

        public static string GetPropertyDisplayName(object descriptor)
        {
            var pd = descriptor as PropertyDescriptor;

            if (pd != null)
            {
                // Check for DisplayName attribute and set the column header accordingly
                var displayName = pd.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;

                if (displayName != null && displayName != DisplayNameAttribute.Default)
                {
                    return displayName.DisplayName;
                }

            }
            else
            {
                var pi = descriptor as PropertyInfo;

                if (pi != null)
                {
                    // Check for DisplayName attribute and set the column header accordingly
                    Object[] attributes = pi.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    for (int i = 0; i < attributes.Length; ++i)
                    {
                        var displayName = attributes[i] as DisplayNameAttribute;
                        if (displayName != null && displayName != DisplayNameAttribute.Default)
                        {
                            return displayName.DisplayName;
                        }
                    }
                }
            }

            return null;
        }
    }
}
