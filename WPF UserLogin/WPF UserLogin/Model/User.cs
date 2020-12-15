using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_UserLogin.Model
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;


        }

        public void InsertInfo(string email)
        {
            string format = string.Format("User has been created!\nEmail: {0}\nPassword: {1}", this.Email, this.Password);

            if (IsValid(email) == true && this.Password != string.Empty)
            {
                MessageBox.Show(format, "User created!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please enter user information!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }
        public bool IsValid(string email)
        {
            if (email != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}

