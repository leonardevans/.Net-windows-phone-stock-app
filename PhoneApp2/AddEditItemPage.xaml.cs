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
    public partial class AddItemPage : PhoneApplicationPage
    {
        public static string itemId = null;
        
        public AddItemPage()
        {
            InitializeComponent();

            txtWelcome.Text = "welcome " + Global.user.username;
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NavigationContext.QueryString.TryGetValue("itemId", out itemId);
            if (itemId != null)
            {
                txtAction.Text = "Edit Item";
                btnAdd.Content = "Update Item";
                Items item = Global.db.getItem(Convert.ToInt32(itemId));
                txtItemname.Text = item.itemname;
                txtPrice.Text = Convert.ToString( item.price);
                txtQuantity.Text = Convert.ToString( item.quantity);
            }
        }


        private void lnkLogout_Click(object sender, RoutedEventArgs e)
        {
            Global.user = null;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string itemname = txtItemname.Text;
            double price ;
            int quantity ;

            if (string.IsNullOrEmpty(itemname))
            {
                MessageBox.Show("Enter item name");
                txtItemname.Focus();
            }
            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Enter price");
                txtPrice.Focus();
            }
            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Enter item name");
                txtQuantity.Focus();
            }
            else
            {
                bool correctInput = true;
                correctInput &= double.TryParse(txtPrice.Text, out price);
                correctInput &= int.TryParse(txtQuantity.Text, out quantity);
                if (!correctInput)
                {
                    MessageBox.Show("Please enter the proper data type");
                }
                else
                {

                    if (itemId != null)
                    {
                        Global.db.updateItem(Convert.ToInt32(itemId), itemname, price, quantity);
                        MessageBox.Show("Item Updated Successfully");
                    }
                    else
                    {
                        Global.db.addItem(itemname, price, quantity);
                        MessageBox.Show("Item Added");
                    }
 
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                    txtItemname.Text = "";
                    NavigationService.Navigate(new Uri("/home.xaml", UriKind.Relative));
                }
                
            }
        }

        private void lnkHome_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/home.xaml", UriKind.Relative));
        }
    }
}