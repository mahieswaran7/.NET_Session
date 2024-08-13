using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAdvance
{
     class Employee
    {

      private  static void Main(string[] args)
        {
            Dictionary<int, string> empdetails;

            empdetails = new Dictionary<int, string>();

            empdetails.Add(100, "Eswaran");

            empdetails.Add(102, "Arumugam");

            empdetails.Add(103, "Jayanthi");

            empdetails.Add(104, "Aravindan");

            string ename = empdetails[102];

             empdetails.Remove(100);

            //1. Contains Key
            Console.WriteLine(empdetails.ContainsKey(100));


            //2. Contains Value
            Console.WriteLine(empdetails.ContainsValue("Eswaran"));

            //3.Remove Method
            Console.WriteLine(empdetails.Remove(103));

            //4.Count
            Console.WriteLine(empdetails.Count);

            Console.WriteLine(ename);

            //Get Type
            Console.WriteLine(empdetails.GetType().ToString());

            //GeT Enumerator

            Console.WriteLine(empdetails.GetEnumerator());



                       
            //SortedList<string, int> Marks;

            //Marks = new SortedList<string, int>();

            //Marks.Add("Maths", 80);

            //Marks.Add("Physics", 90);

            //Marks.Add("English", 65);

            //Marks.Add("Chemistry", 75);

            //foreach (string key in Marks.Keys)

            //{

            //    Console.WriteLine(Marks[key]);

            //}
        }
    }
}
