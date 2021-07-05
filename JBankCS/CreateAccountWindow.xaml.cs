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
using JBankCS.accountFiles;
using System.Windows.Shapes;

namespace JBankCS
{
    /// <summary>
    /// Interaction logic for CreateAccountWindow.xaml
    /// </summary>
    public partial class CreateAccountWindow : Window
    {
        private User user;
        public CreateAccountWindow(User user)
        {
            OperationBox.Items.Add("PLN");
            OperationBox.Items.Add("EUR");
            OperationBox.Items.Add("USD");
            OperationBox.SelectedIndex = 1;

            this.user = user;
            InitializeComponent();

        }
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        private void multiCurrnecy(object sender, RoutedEventArgs e)
        {

        }

        private void createAccount(object sender, RoutedEventArgs e)
        {
            if (newAccountName.Text.Equals(""))
            {
                MessageBox.Show("Error! New account must be named");
            }
            else
            {
                if (checkMultiCurrency.IsChecked == true)
                {
                    MultiCurrencyAccount newAccount = new MultiCurrencyAccount(newAccountName.Text, OperationBox.Text);
                }
                else
                {
                    DefaultAccount newAccount = new DefaultAccount(newAccountName.Text, OperationBox.Text);
                }
                MessageBox.Show("Account is created successfully");
                OpenMainWindow(sender, e);
            }

        }

        private void OpenMainWindow(object sender, RoutedEventArgs e)
        {
            UserMenuWindow objOpenWindow = new UserMenuWindow(this.user);
            this.Close();
            objOpenWindow.Show();
        }
    }
}
