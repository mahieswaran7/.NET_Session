using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class AddToCart
    {

        static void Main(string[] args)
        {
            List<string> food = new List<string>() { "Idly", "Dosa", "Poori", "Pongal" };
            List<int> price = new List<int>() { 100, 200, 300, 400 };

            Console.WriteLine("Menu Card  :");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine("Food Items :" + "Price");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < food.Count; i++)
            {
                Console.WriteLine(food[i] + ":" + price[i]);
            }

            Console.WriteLine();
            string flag = "";
            Console.Write("Select The option  from 1 to 4: ");
            Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
            int option = Convert.ToInt32(Console.ReadLine());
            while (option > 0)
            {
                if (option == 1)
                {
                    Console.WriteLine("Do you want to add the Product (Y/N) :");
                    flag = Console.ReadLine();
                    if (flag == "Y" || flag == "y")
                    {
                        Console.WriteLine("Enter Product Name : ");
                        string item = Console.ReadLine();
                        Console.WriteLine("Enter Product Price : ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        food.Add(item);
                        price.Add(amount);
                        Console.Write("Do You Want To Continue : ");
                        flag = Console.ReadLine();
                        if (flag == "N" || flag == "n")
                        {
                            Console.Write("Select The option  from 1 to 4: ");
                            Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
                            option = Convert.ToInt32(Console.ReadLine());
                        }

                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Do you want to Update the Product (Y/N) :");
                    flag = Console.ReadLine();
                    while (flag == "Y" || flag == "y")
                    {
                        Console.WriteLine("Product Details :");

                        Console.Write("Print the Index to Update :");
                        int no = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Print the Item to Update :");
                        string items = Console.ReadLine();
                        Console.Write("Print the price to Update :");
                        int p = Convert.ToInt32(Console.ReadLine());
                        food[no] = items;
                        price[no] = p;
                        Console.WriteLine(items + "  is Updated successfully");
                        Console.Write("Do You Want To Update Other  (Y/N): ");
                        flag = Console.ReadLine();
                        if (flag == "N" || flag == "n")
                        {
                            Console.Write("Select The option   from 1 to 4: ");
                            Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
                            option = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                }
                else if (option == 3)
                {
                    Console.WriteLine("Do you want to Remove the Product (Y/N) :");
                    flag = Console.ReadLine();
                    if (flag == "Y" || flag == "y")
                    {
                        Console.Write("Print the Index to Remove :");
                        int pro = Convert.ToInt32(Console.ReadLine());

                        food.RemoveAt(pro);
                        price.RemoveAt(pro);
                        Console.WriteLine(pro + " index  is Deleted Successfully!!");
                        Console.Write("Do You Want To Delete Other (Y/N) : ");
                        flag = Console.ReadLine();
                        if (flag == "N" || flag == "n")
                        {
                            Console.Write("Select The option   from 1 to 4: ");
                            Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
                            option = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                }
                else if (option == 4)
                {
                    for (int i = 0; i < food.Count; i++)
                    {
                        Console.WriteLine(food[i] + ":" + price[i]);
                    }
                    Console.Write("Do You Want To View the menu card again : ");
                    flag = Console.ReadLine();
                    if (flag == "N" || flag == "n")
                    {
                        Console.Write("Select The option : ");
                        Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {

                    Console.WriteLine("Invalid Option !!");
                }
            }

        }
    }
}
