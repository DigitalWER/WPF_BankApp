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
using JBankCS.accountFiles;

namespace JBankCS
{
    /// <summary>
    /// Interaction logic for ChangeCurrencyWindow.xaml
    /// </summary>
    public partial class ChangeCurrencyWindow : Window
    {
        readonly double EurToPln = 4.55;
        readonly double UsdToPln = 3.86;
        readonly double Pln = 1;
        readonly double PlnToUsd = 0.23;
        readonly double PlnToEur = 0.20;
        readonly double Eur = 1;
        readonly double Usd = 1;
        readonly double UsdToEur = 0.82;
        readonly double EurToUsd = 1.15;

        private User _user;
        private Account _account;
        public ChangeCurrencyWindow(User user, Account account)
        {
            _user = user;
            _account = account;
            InitializeComponent();
            currencyBox.Items.Add("PLN");
            currencyBox.Items.Add("EUR");
            currencyBox.Items.Add("USD");
            accountName.Content = _account.AccountName;
            accountNumber.Content = _account.AccountNumber;
            activeCurrency.Content = _account.MainCurrency;
            funds.Content = _account.Funds;
            
        }

        private void backToTheMainMenu(object sender, RoutedEventArgs e)
        {
            UserMenuWindow objOpenWindow = new UserMenuWindow(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void changeCurrency(object sender, RoutedEventArgs e)
        {
            _account.Withdraw(_account.Funds);
            _account.Deposit(double.Parse(newFunds.Content.ToString()));
            _account.MainCurrency = currencyBox.SelectedItem.ToString();
            backToTheMainMenu(sender, e);
            MessageBox.Show("Operation completed");
        }

        private void newCurrencyChange(object sender, SelectionChangedEventArgs e)
        {
            exchangeRate.Content = checkCurrency(_account.MainCurrency, currencyBox.SelectedItem.ToString());
            newFunds.Content = _account.Funds * double.Parse(exchangeRate.Content.ToString());
        }

        public double checkCurrency(string currency, string newCurrency)
        {
            switch (currency)
            {
                case "PLN":
                    switch (newCurrency)
                    {
                        case "EUR":
                            return PlnToEur;
                        case "USD":
                            return PlnToUsd;
                        default:
                            return Pln;
                    }
                case "EUR":
                    switch (newCurrency)
                    {
                        case "PLN":
                            return EurToPln;
                        case "USD":
                            return EurToUsd;
                        default:
                            return Eur;
                    }
                default:
                    switch (newCurrency)
                    {
                        case "PLN":
                            return UsdToPln;
                        case "EUR":
                            return UsdToEur;
                        default:
                            return Usd;
                    }
            }
        }
    }
}
