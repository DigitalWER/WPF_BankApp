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
        public StartWindowSignIn()
        {
            InitializeComponent();
        }

        private void SignUpOpen(object sender, RoutedEventArgs e)
        {
            RegistrationWindow objOpenWindow = new RegistrationWindow();
            this.Close();
            objOpenWindow.Show();
        }
    }
}
