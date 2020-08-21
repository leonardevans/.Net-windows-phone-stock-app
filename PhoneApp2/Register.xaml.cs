using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp2
{
    public partial class Register : PhoneApplicationPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            string confirmPassword = txtConfirmPassword.Password;

            //check empty value
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username");
                txtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password");
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please confirm password");
                txtConfirmPassword.Focus();
            }
            else
            {
                if (password.Equals(confirmPassword))
                {
                    DatabaseOperations db = new DatabaseOperations();
                    Users user = db.getUser(username);
                    if (user == null)
                    {
                        db.addUser(username, password);
                        MessageBox.Show("Account created");
                        txtUsername.Text = "";
                        txtPassword.Password = "";
                        txtConfirmPassword.Password = "";
                        NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                    }
                    else
                    {
                        MessageBox.Show("Username exists. Enter unique username");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords should match");
                    txtPassword.Focus();
                    txtConfirmPassword.Focus();
                }
            }
        }

        private void lnkLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        
    }
}