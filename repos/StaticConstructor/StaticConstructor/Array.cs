using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class ArrayDemo
    {

         private static void Main(String[] args)
        {

            string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //Console.WriteLine(weekdays[1]);
            Console.WriteLine(weekdays.Length);
            /* for (int i = 0; i < weekdays.Length; i++)
             {
                 Console.WriteLine(weekdays[i]);
             }
            */



            foreach (string day in weekdays)
            {
                Console.WriteLine(day);
            }


            /*Array.Sort(weekdays);

            Console.WriteLine("Sorted in Ascending");

            foreach (string day in weekdays )
            {
                Console.WriteLine(day);
            }

            Array.Reverse(weekdays);

            Console.WriteLine("Sorted in Descending ");

            foreach (string day in weekdays)
            {
                Console.WriteLine(day);
            }
            */
            //int daypos = Array.IndexOf(weekdays, "Wed");

            //Console.WriteLine("Wednesday is " + (daypos + 1) + " day of week ");

            //Array.Clear(weekdays, 0, 2);

            //weekdays[0] = "Sunday";
            //Array.Resize(ref weekdays, 7);
            //weekdays[6] = "Some Special Day";
            Console.WriteLine("======================= ");
            string[] weekdays_copy = new string[7];
            //weekdays.Append("independance day");
            weekdays.CopyTo(weekdays_copy, 0);

            foreach (string day in weekdays_copy)
            {
                Console.WriteLine(day);
            }

            ///Month Task

            string[] months = { "Jan", "Feb", "Mar", "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ////Sort an array
            Console.WriteLine("Sorted Array in Asscending Order :");
            Array.Sort(months);
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }
            ////Reverse an array
            Console.WriteLine("Reverse the Sorted Array :");
            Array.Reverse(months);
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }
            //Index of Particular Month

            int monthnumber = Array.IndexOf(months, "Jan");

            Console.WriteLine("Number of the Month :" + (monthnumber + 1));

            //Clear one particular index value(it will only make empty).
            Console.WriteLine("Removing one value from the array :");
            Array.Clear(months, 0, 1);
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }

            //Inserting a value in one particular index
            Console.WriteLine("Inserting one value from the array :");
            months[0] = "september";
            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }

            Array.Resize(ref months, 13);
            months[12] = "Festival Month";

            foreach (string mon in months)
            {
                Console.WriteLine(mon);
            }

            //Copy Array
            Console.WriteLine("Copying to Another Array");
            string[] copy_months = new string[months.Length];
            months.CopyTo(copy_months, 0);

            foreach (string cmon in copy_months)
            {
                Console.WriteLine(cmon);
            }
        }



    }
    }


