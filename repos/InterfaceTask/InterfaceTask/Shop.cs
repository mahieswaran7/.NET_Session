using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class Shop
    {

        public string shopName;
        public string product_name { get; set; }
        public double product_price { get; set; }
        public string product_category { get; set; }
        public string outlet_name { get; set; }
        public string outlet_city { get; set; }
        public string outlet_location { get; set; }

        public string getOutletDetails()
        {
            Console.WriteLine("Outlet Details:");
            Console.WriteLine("---------------------------------------------------");


            Console.WriteLine("Shop Name :" + shopName);
            string details = "Outlet Name : " + this.outlet_name + "," + "\n" +
                             "Outlet_city :" + this.outlet_city + "," + "\n" +
                             "Outlet_location :" + this.outlet_location;
            return details;
        }

        public string getProductDetails()
        {
            Console.WriteLine("Product Details :");
            string proDetails = "ProductName : " + this.product_name + " ," + "\n"
                             + "Product Price :" + this.product_price + "," + "\n" +
                             "Product Category : " + this.product_category;
            return proDetails;
        }
    }
}
