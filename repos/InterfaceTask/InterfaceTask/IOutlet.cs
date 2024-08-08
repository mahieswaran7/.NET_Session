using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    abstract class IOutlet
    {
        string outlet_name { get; set; }
        string outlet_city { get; set; }
        string outlet_location { get; set; }


        public abstract string getOutletDetails();
    }
   
}
