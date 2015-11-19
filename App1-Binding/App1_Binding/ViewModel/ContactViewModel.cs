using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1_Binding.ViewModel
{
    public class ContactViewModel
    {
        public ContactViewModel(Contact contact)
        {
            FullName = contact.FirstName + " " + contact.LastName;
            Email = contact.Email;
            Phone = contact.PhoneNo;
            Age = CalculateAge(contact.BirthDate);
        }

        public int Age { get; set; }

        public object Phone { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }
        private int CalculateAge(DateTime birthDate)
        {
            var now = float.Parse(DateTime.Now.ToString("yyy.MMdd"));
            var dob = float.Parse(birthDate.ToString("yyy.MMdd"));
            var age = (int)(now - dob);
            return age;
        }
    }
}
