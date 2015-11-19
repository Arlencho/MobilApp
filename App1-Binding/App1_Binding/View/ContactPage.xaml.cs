using App1_Binding.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1_Binding
{
    public partial class ContactPage : ContentPage
    {
        public ContactViewModel _Contact;

        public ContactPage(Contact contact)
        {
            _Contact = new ContactViewModel(contact);
            InitializeComponent();
            BindingContext = _Contact;
        }
    }
}
