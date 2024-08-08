//Day1


class Program
{
    private static void Main(string[] args)
    {
        ////Use of ReadKey() and Clear() 
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();
        //Console.Clear();
        //Console.WriteLine("Welcome to .net Class");
        //Console.ReadKey();
        //Console.WriteLine("DAy 1");

        ////VARIABLE
        //int num = 10;
        //Console.WriteLine(num);

        //sbyte sb = 10;
        //byte b = 20;
        //short s = 30;
        //ushort us = 40;
        //int i = 50;
        //uint ui = 60;
        //long l = 222;
        //ulong ul = 233434;
        //float f = 123.22F;
        //double d = 100.432D;
        //decimal dec = 100.32456M;

        //Console.WriteLine(sb);
        //Console.WriteLine(b);
        //Console.WriteLine(s);
        //Console.WriteLine(us);
        //Console.WriteLine(i);
        //Console.WriteLine(ui);
        //Console.WriteLine(l);
        //Console.WriteLine(ul);
        //Console.WriteLine(f);
        //Console.WriteLine(d);
        //Console.WriteLine(dec);

        ////TO FIND THE MIN AND MAX VALUE OF THE DATATYPE: MinValue() and MaxVAlue()

        //int min = int.MinValue;
        //int max = int.MaxValue;

        //Console.WriteLine(min);
        //Console.WriteLine(max);

        ////Char and String

        //char ch = 'A';
        //Console.WriteLine(ch);

        //string str = "Shiva 1!@#";
        //Console.WriteLine(str);

        ////Boolean

        //bool isAdult = true;
        //Console.WriteLine(isAdult);

        //*************************OPERATORS**************************//
        //ARITHMETIC OPERATOR

        //double num1 = 10; double num2 = 20;
        //Console.WriteLine( num1+num2);
        //Console.WriteLine(num1 - num2);
        //Console.WriteLine(num1 * num2);
        //Console.WriteLine(num1 / num2);
        //Console.WriteLine( num1 % num2);

        ////PERFORMING OPERATION AS WELL AS STORING VALUE IN NUM1
        //Console.WriteLine(num1 += num2);
        //Console.WriteLine(num1 -= num2);
        //Console.WriteLine(num1 *= num2);
        //Console.WriteLine(num1 /= num2);
        //Console.WriteLine(num1 %= num2);


        ////LOGICAL OPERATOR
        //Console.WriteLine("AND OPERATOR");
        //int x = 10; int y = 20; int z = 10;
        //bool result=(x >= y && x <= z);
        //Console.WriteLine(result);

        //Console.WriteLine("OR OPERATOR");

        //bool result2 = (x >= y || x <= z);
        //Console.WriteLine(result2);

        ////TERNARY OPERATOR

        //int value = 12;
        //string state = ((value % 2 == 0) ? "Even " : "Odd");
        //Console.WriteLine(state);
        ////LEAP YEAR TASK
        //Console.WriteLine("ENTer the year");
        //int year = Convert.ToInt32(Console.ReadLine());
        //if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        //{
        //    Console.WriteLine(year + " is Leap Year");
        //}
        //else
        //{
        //    Console.WriteLine(year + "is not an Leap Year");
        //}

        ////USING TERNARY OPERATOR

        //string LOP = ((year % 400 == 0 || year % 4 == 0 && year % 100 != 0) ? "Leap Year" : "Not An Leap Year");
        //Console.WriteLine(LOP);

        //int marks = 76;

        //if (marks >= 75)
        //{
        //    Console.WriteLine("Distinction");
        //}
        //else if (marks >= 60 && marks < 75)
        //{
        //    Console.WriteLine("First Class");
        //}
        //else if (marks >= 50 && marks < 60)
        //{
        //    Console.WriteLine("Second class");
        //}
        //else if (marks >= 35 && marks < 50)
        //{
        //    Console.WriteLine("Third Class");
        //}
        //else
        //{
        //    Console.WriteLine("Fail...");
        //}


        ////GREATEST OF ALL NUMBER

        //int num1 = 40; int num2 = 40; int num3 =30;

        //if ((num1 >=num2 && num1 >=num3)) {
        //    Console.WriteLine(num1 + " is the gretest Number");
        //} else if ((num2 > num1 && num2 > num3)) {
        //    Console.WriteLine(num2 +" is greatest number ");
        //} else {
        //    Console.WriteLine(num3 + "is greatest NUmber");
        //        }
        //Console.WriteLine("Enter the Month number:");

        //string monthname = "";
        //int monthno = Convert.ToInt32(Console.ReadLine());
        //switch(monthno)
        //{
        //    case 1: monthname = "January";
        //        break;
        //    case 2:
        //        monthname = "February";
        //        break;
        //    case 3:
        //        monthname = "March";
        //        break;
        //    case 4:
        //        monthname = "April";
        //        break;
        //    case 5:
        //        monthname = "May";
        //        break;
        //    case 6:
        //        monthname = "June";
        //        break;
        //    case 7:
        //        monthname = "July";
        //        break;
        //    case 8:
        //        monthname = "August";
        //        break;
        //    case 9:
        //        monthname = "September";
        //        break;
        //    case 10:
        //        monthname = "October";
        //        break;
        //    case 11:
        //        monthname = "November";
        //        break;
        //    case 12:
        //        monthname = "December";
        //        break;



        //}

        //Console.WriteLine(monthname);

        ////FACTORIAL OF A NUMBER
        /*
        Console.WriteLine("Enter the number :");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        int temp = num;
        while(num > 1) {
        fact=fact*num;
            num--;

        }
        Console.WriteLine("Factorial of  "+ temp + "  is  :" + fact);
        */

        ////DO-WHILE LOOP
        //int i = 1;
        //int sumofodds = 0;
        //do
        //{
        //    if (i % 2 != 0)
        //    {
        //        sumofodds += i;
        //    }
        //    i++;
        //} while (i <100);
        //Console.WriteLine("Sum Of Odd Numbers between 1 to 100 : " + sumofodds);


        ////FOR-LOOP
        ///
        //int sumofnums = 0;

        //for(int i=0;i<100;i++)
        //{
        //    if (i % 10== 0) {
        //        sumofnums += i;
        //    }
        //}
        //Console.WriteLine("Sum Of Numbers  : " + sumofnums);


        ////SUM OF DIGITS

        // int num = 64351;
        // int temp = num;
        // int value = 0;
        // int sum = 0;
        // while(num>0)
        // {
        //     value = num % 10;
        //     sum += value;
        //     num = num / 10;
        // }

        //Console.WriteLine(sum);


        ////Prime Number

        int num = 11;
        int count = 0;
        if (num == 1)
        {
            Console.WriteLine("Neither or Nor Prime Number");
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }

            }
            if (count > 2)
            {
                Console.WriteLine(num + "  is not Prime NUmber");
            }
            else
            {
                Console.WriteLine(num + "  is  Prime NUmber");
            }
        }

    }
}
