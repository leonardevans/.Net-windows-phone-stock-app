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
    public partial class home : PhoneApplicationPage
    {
        public home()
        {
            InitializeComponent();

            txtWelcome.Text = "welcome " + Global.user.username;
            List<Items> items = Global.db.getItems();
            
             listItems.ItemsSource = items;
            
            



            ApplicationBar  = new ApplicationBar();
            ApplicationBarIconButton add = new ApplicationBarIconButton();
            add.Text = "Add";
            add.IconUri = new Uri("/icon/add.png", UriKind.Relative);
            ApplicationBar.Buttons.Add(add);
            add.Click += add_Click;

            ApplicationBarIconButton edit = new ApplicationBarIconButton();
            edit.Text = "edit";
            edit.IconUri = new Uri("/icon/edit.png", UriKind.Relative);
            ApplicationBar.Buttons.Add(edit);
            edit.Click += edit_Click;

            ApplicationBarIconButton delete = new ApplicationBarIconButton();
            delete.Text = "delete";
            delete.IconUri = new Uri("/icon/delete.png", UriKind.Relative);
            ApplicationBar.Buttons.Add(delete);
            delete.Click += delete_Click;
        }

        void edit_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected to edit");
                return;
            }
            Items item = listItems.SelectedItem as Items;
            
            NavigationService.Navigate(new Uri(string.Format("/AddEditItemPage.xaml?itemId={0}",item.id ), UriKind.Relative));

        }

        void delete_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected to delete");
                return;
            }
            Items item = listItems.SelectedItem as Items;
            Global.db.deleteItem(item.id);
            listItems.ItemsSource = null;
            listItems.ItemsSource = Global.db.getItems();
            MessageBox.Show("Item deleted successfully");

        }

        void add_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddEDitItemPage.xaml", UriKind.Relative));
        }

        private void lnkLogout_Click(object sender, RoutedEventArgs e)
        {
            Global.user = null;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) {
                listItems.ItemsSource = Global.db.getItems();
            }
            else
            {
                string searched = txtSearch.Text;
                listItems.ItemsSource = Global.db.searchItems(searched);
            }
            


        }

       
    }
}