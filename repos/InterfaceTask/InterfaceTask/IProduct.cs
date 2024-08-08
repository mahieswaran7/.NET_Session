using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal interface IProduct
    {

        string product_name { get; set; }
        double product_price { get; set; }
        string product_category { get; set; }

        public string getProductDetails();
    }
}
