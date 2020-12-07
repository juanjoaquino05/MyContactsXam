using MyContactsXam.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyContactsXam.ViewModels
{
    public class NewContactViewModel : BaseViewModel
    {
        public Command AddCommand { get; }

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private string name;
        public string Number
        {
            get { return number; }
            set { SetProperty(ref number, value); }
        }
        private string number;

        public NewContactViewModel()
        {
            AddCommand = new Command(NewContact);

        }

        private async void NewContact()
        {
            var newContact = new Contact();
            newContact.Name = Name;
            newContact.Number = Number;

            MainViewModel.GetInstance().ContactsPage.Contacts.Add(newContact);
            
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
