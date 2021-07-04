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
            OperationBox.Items.Add("Dokonaj Wplaty");
            OperationBox.Items.Add("Dokonaj Wyplaty");
            OperationBox.SelectedIndex = 1;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if((string)OperationBox.SelectedItem == "Dokonaj Wplaty")
            {
                user.GetAccount().Deposit(100);
            }
            else
            {
                if(!user.GetAccount().Withdraw(100))
                {
                    MessageBox.Show("zbyt mala ilosc pieniedzy na koncie");
                }
                else
                {
                    MessageBox.Show("Dokonano operacji");
                }
            }
        }
    }
}
