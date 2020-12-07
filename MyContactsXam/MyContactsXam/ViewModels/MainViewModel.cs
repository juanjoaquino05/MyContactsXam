using System;
using System.Collections.Generic;
using System.Text;

namespace MyContactsXam.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public ContactsPageViewModel ContactsPage { get; set; }
        public NewContactViewModel NewContactPage { get; set; }
        #endregion

        #region Contructors
        public MainViewModel()
        {
            instace = this;
            this.ContactsPage = new ContactsPageViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instace;

        public static MainViewModel GetInstance()
        {
            if(instace == null)
            {
                return new MainViewModel();
            }

            return instace;
        }
        #endregion
    }
}
