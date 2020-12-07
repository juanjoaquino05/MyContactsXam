using MyContactsXam.Models;
using MyContactsXam.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyContactsXam
{
    public partial class App : Application
    {
        //public static List<Contact> contacts { get; set; }
        public App()
        {
            InitializeComponent();

            //contacts = new List<Contact>();
            //contacts.Add(new Contact() { Name = "Juan", Number = "809" });

            MainPage = new NavigationPage(new ContactsPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
