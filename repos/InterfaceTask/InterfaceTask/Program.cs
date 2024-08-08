using InterfaceTask;
class Program
{
    public static void Main(String[] args)
    {
        Shop shop = new Shop();
        shop.shopName = "Lenovo";
        shop.product_name = "Lenovo A33";
        shop.product_price = 52000;
        shop.product_category = "Office Laptop";
        shop.outlet_name = "LENOVO FACTORY";
        shop.outlet_city = "Japan";
        shop.outlet_location = "Tokyo";

        Console.WriteLine(shop.getProductDetails());
        Console.WriteLine(shop.getOutletDetails());
    }
}