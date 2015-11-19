using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Binding.ViewModel;
using Xamarin.Forms;

namespace App1_Binding
{
    public partial class ContactListPage : ContentPage
    {
        private ContactListViewModel _contactListViewModel;
        public ContactListPage()
        {
            _contactListViewModel = new ContactListViewModel();
            InitializeComponent();
            BindingContext = _contactListViewModel;
        }

        private void ContactList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = (Contact ) e.Item;
            if (e != null)
            {
                Navigation.PushAsync(new ContactPage(contact));
            }
        }
    }
}
