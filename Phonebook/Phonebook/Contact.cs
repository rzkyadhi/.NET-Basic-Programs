using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            if (name == null) throw new ArgumentNullException(nameof(name), "Name cannot be null");
            else if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name), "Name cannot null or empty");
            else if (name.EndsWith(" ")) throw new ArgumentException(nameof(name), "Name cannot ends with space");
            else Name = name;

            if (number == null) throw new ArgumentNullException(nameof(number), "Number cannot be null");
            else if (string.IsNullOrEmpty(number)) throw new ArgumentNullException(nameof(number), "Number cannot null or empty");
            else if (name.EndsWith(" ")) throw new ArgumentException(nameof(number), "Number cannot ends with space");
            else Number = number;
        }
    }
}
