

//class Program
//{
//    private static void Main(string[] args)
//    {
//        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
//        //Console.WriteLine(products[0]);
//        //foreach (string product in products)
//        //{
//        //    Console.WriteLine(product);
//        //}

//        string flag = "Y";
//        string item = "";
//        while (flag == "Y" || flag == "y")
//        {
//            Console.Write("Enter the Product to Add : ");
//            item = Console.ReadLine();
//            products.Add(item);
//            Console.Write("Want to add more product press Y: ");
//            flag = Console.ReadLine();

//        }
//        Console.Write("Enter the Product to Add at the start : ");
//        item = Console.ReadLine();
//        products.Insert(0, item);
//        Console.WriteLine("Products List");
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }

//        List<string> fruits = new List<string> { "Apple", "Kiwi", "Banana" };
//        Console.WriteLine("Do you want to clear the list before adding the fruit list");
//        flag = Console.ReadLine();
//        if (flag == "Y" || flag == "y")
//        {
//            products.Clear();
//        }
//        products.AddRange(fruits);
//        Console.WriteLine("Products List and Fruit List");
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }
//        Console.Write("Which item to Remove: ");
//        item = Console.ReadLine();
//        products.Remove(item);

//        Console.WriteLine("List after removing the item: " + item);
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }
//        Console.Write("Which position item to be removed: ");
//        int pos = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("List after removing the item at position : " + pos);
//        products.RemoveAt(pos);
//        foreach (string product in products)
//        {
//            Console.WriteLine(product);
//        }
//    }
//}





