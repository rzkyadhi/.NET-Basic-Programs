using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
    }
}
