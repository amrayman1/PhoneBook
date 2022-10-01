using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookProject
{
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string _name, string _number)
        {
            Name = _name;
            Number = _number;
        }
    }
}
