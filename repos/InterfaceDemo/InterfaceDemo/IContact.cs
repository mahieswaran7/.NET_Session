using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IContact
    {
        public string Name { get; set; }
        public string Email { get; set; }

        void ContactDetails();
    }
}