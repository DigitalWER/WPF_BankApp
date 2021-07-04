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
using JBankCS;

namespace JBankCS
{
    /// <summary>
    /// Interaction logic for StartWindowSignIn.xaml
    /// </summary>
    public partial class StartWindowSignIn : Window
    {
        private List<User> users = new List<User>();
        public StartWindowSignIn()
        {
            InitializeComponent();
            users.Add(new User("Marian", "Kowalski", 923485762, "Golembie@ptaki.pl", "User1", "Passowrd1"));
            users.Add(new User("Norbert", "Nowak", 923485762, "Orangutany@malpy.pl", "User", "asdasd"));
        }

        private void SignUpOpen(object sender, RoutedEventArgs e)
        {
            RegistrationWindow objOpenWindow = new RegistrationWindow();
            this.Close();
            objOpenWindow.Show();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            bool succesfulLogin = false;
            foreach(User user in users)
            {
                if (string.Equals(user.getUsername(), UsernameTextbox.Text));
                {
                    if (string.Equals(user.getPassword(), PassowrdPassowrdBox.Password));
                    {
                        UserMenuWindow umw1 = new UserMenuWindow(user);
                        succesfulLogin = true;
                        umw1.Show();
                        this.Close();
                        break;
                    }
                }
            }
            if(!succesfulLogin)
                MessageBox.Show("Incorrect login or password");
        }
    }
}
