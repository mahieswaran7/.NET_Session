using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Linq
    {

        private static void Main(string[] args)
        {

            //Linq


            //List<int> ints = new List<int> { 10, 20, 33, 40, 55 };
            //List<int> evenlist = new List<int>();

            //evenlist = (from item in ints where (item % 2 == 0) select item).ToList();

            //foreach (int i in evenlist)
            //{
            //    Console.WriteLine(i);
            //}


            List<string> menuItem = new List<string>() {"Egg","Chicken","Prawn","Fish"};
           
            List<string> food = new List<string>();
            Console.WriteLine("Enter the Food you want: ");
            string menu=Console.ReadLine();
            food = (from item in menuItem where item.Equals(menu,StringComparison.OrdinalIgnoreCase) select item).ToList();
            foreach (string i in food)
            {
               Console.WriteLine(i+" your favourite food is in the menu");
            }


      

        }
    }
}
