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
        private User _user;
        //private List<TransactionHistory> _transactionsCopy;

        public TransactionHistoryWindow(User user)
        {
            InitializeComponent();
            _user = user;
            totalMoney.Content = sumOfMoney(user.GetTransactionHistory).ToString();
            numOfOperations.Content = user.GetTransactionHistory.Count().ToString();
            resetDataGrid();
        }

        private void openUserMenuWindow(object sender, RoutedEventArgs e)
        {
            UserMenuWindow objOpenWindow = new UserMenuWindow(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void resetDataGrid()
        {
            transactionsDataGrid.ItemsSource = null;
            transactionsDataGrid.ItemsSource = _user.GetTransactionHistory;
        }

        private double sumOfMoney(List<TransactionHistory> transactions)
        {
            double sum = 0;
            foreach (TransactionHistory transaction in transactions)
            {
                if (transaction.Operation.Equals("Deposit"))
                    sum += transaction.AmountOfMoney;
                else
                    sum -= transaction.AmountOfMoney;
            }
            return sum;
        }

        /*
         * private void SelectedDateFrom(object sender, SelectionChangedEventArgs e)
        {
            DateTime dateFrom = From.SelectedDate.Value;
            foreach (var transaction in user.GetTransactionHistory)
            {
                if (transaction.Date<=dateFrom)
                {
                    _transactionsCopy.Add(transaction);
                }
            }
        }

        private void SelectedDateTo(object sender, SelectionChangedEventArgs e)
        {
            DateTime dateTo = To.SelectedDate.Value;
            if (_transactionsCopy==null)
                filteredLoop(user.GetTransactionHistory, dateTo);
            else
                filteredLoop(_transactionsCopy, dateTo);
        }

        private void filteredLoop(List<TransactionHistory> transactions, DateTime date)
        {
            List<TransactionHistory> transactionsCloned = transactions;
            foreach (var transaction in transactions)
            {
                if (transaction.Date >= date)
                {
                    if (!transactionsCloned.Contains(transaction))
                    {
                        transactionsCloned.Add(transaction);
                    }
                }
                else
                {
                    transactionsCloned.Remove(transaction);
                }
            }
        }
        */

        private void SelectedDateFrom(object sender, SelectionChangedEventArgs e)
        {
            filteredLoop();
        }


        private void SelectedDateTo(object sender, SelectionChangedEventArgs e)
        {
            filteredLoop();
        }

        private void filteredLoop()
        {
            List<TransactionHistory> transactionsCloned = _user.GetTransactionHistory;
            if (From != null || To != null)
            {
                if (From.SelectedDate != null || To.SelectedDate != null)
                {
                    if (From.SelectedDate != null)
                    {
                        transactionsCloned = transactionsCloned.FindAll(delegate (TransactionHistory transaction) { return From.SelectedDate <= transaction.Date; });
                    }
                    if (To.SelectedDate != null)
                    {
                        transactionsCloned = transactionsCloned.FindAll(delegate (TransactionHistory transaction) { return To.SelectedDate >= transaction.Date; });
                    }
                }
            }
            transactionsDataGrid.ItemsSource = null;
            transactionsDataGrid.ItemsSource = transactionsCloned;
            totalMoney.Content = sumOfMoney(transactionsCloned).ToString();
            numOfOperations.Content = transactionsCloned.Count().ToString();
        }
    }
}
