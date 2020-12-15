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
using WPF_sekvensdiagrammer1.ViewModels;

namespace WPF_sekvensdiagrammer1.Views.Pages
{

    public partial class LoginPage : Page
    {
        public LoginPage()
        { 
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = string.Empty;
            string password = string.Empty;

            email = txtEmail.Text;
            password = txtPassword.Text;

            string format = string.Format("Email: {0}\nPassword: {1}", email, password);
            if (email != string.Empty && password != string.Empty)
            {
                MessageBox.Show(format, "User created!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please enter user information!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            txtEmail.Clear();
            txtPassword.Clear();

        }

    }

}
