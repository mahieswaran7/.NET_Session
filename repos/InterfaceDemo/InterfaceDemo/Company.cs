using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
     class Company : IContact,IAddress
    {
        public string Name { get; set; }
        public string addressline1 { get ; set ; }
        public string city { get ; set ; }
        public string state { get; set ; }
        public string postcode { get; set ; }
        public string Email { get ; set ; }

        public void addressDetails()
        {
            Console.WriteLine("Company Name: " + this.Name);
            Console.WriteLine("Address Line 1: " + this.addressline1 + "\n" + "City: " + this.city + "\n" + "State: " + this.state + "\n" + "PostCode: " + this.postcode);
        }

       
        public void ContactDetails()
        {
            Console.WriteLine("Email: " + this.Email + "\n" + "Mobile Number:" + this.postcode);
        }
    }
}

