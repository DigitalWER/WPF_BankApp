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
    /// Interaction logic for TransactionHistoryWindow.xaml
    /// </summary>
    public partial class TransactionHistoryWindow : Window
    {
        private User user;
        private List<TransactionHistory> _transactionsCopy;

        public TransactionHistoryWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            _transactionsCopy = user.GetTransactionHistory;
            totalMoney.Content = sumOfMoney(_transactionsCopy).ToString();
            numOfOperations.Content = _transactionsCopy.Count().ToString();
            resetDataGrid();
        }

        private void openUserMenuWindow(object sender, RoutedEventArgs e)
        {
            UserMenuWindow objOpenWindow = new UserMenuWindow(user);
            this.Close();
            objOpenWindow.Show();
        }

        private void resetDataGrid()
        {
            accountListDataGrid.ItemsSource = null;
            accountListDataGrid.ItemsSource = user.GetTransactionHistory;
        }

        
        private double sumOfMoney(List<TransactionHistory> transactions)
        {
            double sum=0;
            foreach (TransactionHistory transaction in transactions)
            {
                sum += transaction.AmountOfMoney;
            }
            return sum;
        }
    }
}
