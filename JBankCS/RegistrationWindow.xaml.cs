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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JBankCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private string _password;
        private string _checkPassword;
        public RegistrationWindow()
        {
            InitializeComponent();

        }

        private void OpenStartWindow(object sender, RoutedEventArgs e)
        {
            StartWindowSignIn objOpenWindow = new StartWindowSignIn();
            this.Close();
            objOpenWindow.Show();
        }

        private void SignUpAndOpenMainPage(object sender, RoutedEventArgs e)
        {
            _password = password.Password;
            _checkPassword = checkPassword.Password;
            if (_password.Equals(_checkPassword) && _password != "" && int.TryParse(this.phoneNumber.Text, out int phoneNumber) && this.phoneNumber.Text.Length == 9 && this.username.Text != "" && this.firstName.Text != "" && this.lastName.Text !="" && email.Text != "")
            {
                User newUser = new User(firstName.Text, lastName.Text, phoneNumber, email.Text, username.Text, password.Password);
                OpenStartWindow(sender, e);
                MessageBox.Show("New user is created! You can log in now.");
            }
            else
            {
                MessageBox.Show("Inputted passwords doesn't match. Please check your inputs again.");
            }
            
        }
    }
}
