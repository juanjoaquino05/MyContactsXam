using MyContactsXam.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MyContactsXam.ViewModels
{
    public class ContactsPageViewModel : BaseViewModel
    {
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set { SetProperty(ref _contacts, value); }
        }

        public Contact SelectedContact { get; set; }
        public ContactsPageViewModel()
        {
            //AddCommand = new Command(NewContact);
            Contacts.Add(new Contact() { Name = "juan", Number = "123" });
        }

        //private async void NewContact()
        //{
        //    var newContact = new Contact();
        //    newContact.Name = Name;
        //    newContact.Number = Number;

        //    App.contacts.Add(newContact);

        //    await Application.Current.MainPage.Navigation.PopAsync();
        //}
    }
}
