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
    /// Interaction logic for userOptions.xaml
    /// </summary>
    public partial class userOptions : Window
    {
        private User _user;
        public userOptions(User user)
        {
            _user = user;
            InitializeComponent();
            firstName.Content = user.getFirstName();
            LastName.Content = user.getLastName();
            Email.Content = user.getEmail();
            Username.Content = user.getUsername();
            phoneNumber.Content = user.getPhoneNumber();
        }

        private void openMainMenu(object sender, RoutedEventArgs e)
        {
            UserMenuWindow objOpenWindow = new UserMenuWindow(_user);
            this.Close();
            objOpenWindow.Show();
        }

        private void updateDataAndCheck(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(checkExistingPassword.Password) || checkExistingPassword.Password!=_user.getPassword())
            {
                MessageBox.Show("Password box is empty or inputted password doesn't match with the existing one");
            }
            else
            {
                if (!string.IsNullOrEmpty(firstNameBox.Text))
                {
                    _user.setFirstName(firstNameBox.Text);
                }

                if (!string.IsNullOrEmpty(lastNameBox.Text))
                {
                    _user.setLastName(lastNameBox.Text);
                }

                if (!string.IsNullOrEmpty(emailNameBox.Text))
                {
                    _user.setEmail(emailNameBox.Text);
                }

                if (!string.IsNullOrEmpty(usernameBox.Text))
                {
                    _user.setUsername(usernameBox.Text);
                }

                if (!string.IsNullOrEmpty(phoneNumBoxBox.Text))
                {
                    _user.setPhoneNumber(phoneNumBoxBox.Text);
                }

                if (!string.IsNullOrEmpty(passwordBox.Password))
                {
                    _user.setPassword(passwordBox.Password);
                }

                MessageBox.Show("Data are updated");
                openMainMenu(sender, e);
            }
        }
    }
}
