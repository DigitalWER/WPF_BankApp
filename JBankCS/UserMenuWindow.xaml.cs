﻿using System;
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
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (moneyAmountOperation.Text!="")
            {
                if ((string)OperationBox.SelectedItem == "Deposit")
                {
                    user.GetAccount().Deposit(Int32.Parse(moneyAmountOperation.Text));
                    MessageBox.Show("Deposit is completed");
                }
                else
                {
                    if (!user.GetAccount().Withdraw(Int32.Parse(moneyAmountOperation.Text)))
                    {
                        MessageBox.Show("Not enough money in the account to complete the operation");
                    }
                    else
                    {
                        MessageBox.Show("Operation completed");
                    }
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
            CreateAccountWindow objOpenWindow = new CreateAccountWindow();
            this.Close();
            objOpenWindow.Show();
        }
    }
}
