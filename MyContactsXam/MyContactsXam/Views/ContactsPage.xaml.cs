using MyContactsXam.Models;
using MyContactsXam.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyContactsXam.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            ToolbarItem add = new ToolbarItem();
            add.Text = "Add";
            add.Priority = 5;
            add.Order = ToolbarItemOrder.Primary;
            add.Clicked += AddContact;

            ToolbarItems.Add(add);

            ToolbarItem delete = new ToolbarItem();
            delete.Text = "Delete";
            delete.Priority = 5;
            delete.Order = ToolbarItemOrder.Primary;
            delete.Clicked += DeleteContact;

            ToolbarItems.Add(delete);

        }

        async private void AddContact(object sender, EventArgs e)
        {
            MainViewModel.GetInstance().NewContactPage = new NewContactViewModel();
            await Navigation.PushAsync(new NewContactPage());
        }

        async private void DeleteContact(object sender, EventArgs e)
        {
            var selected = MainViewModel.GetInstance().ContactsPage.SelectedContact;
            if (selected != null)
            {   
                MainViewModel.GetInstance().ContactsPage.Contacts.Remove(selected);
            }

            await App.Current.MainPage.DisplayAlert("Alert", selected.Name + " was deleted", "OK");
        }
    }
}
