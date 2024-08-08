using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    //class Age
    //{
    //    public readonly int _year;

    //    public Age(int year)
    //    {
    //        this._year = year;
    //        Console.WriteLine(this._year);
    //    }
    //}



    class User
    {
        private string userName;
        private string password;
        private string message;
        private string address;
        private bool isMarried = false;


        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

        }
        public User(string userName, string password, string message)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;

        }
        public User(string userName, string password, string message, string address)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.address = address;

        }
        public User(string userName, string password, string message, string address, bool isMarried)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.address = address;
            this.isMarried = isMarried;

        }
        public void getDetails()
        {
            Console.WriteLine("USername : " + userName);
            Console.WriteLine("Password : " + password);

            if (this.address != null)
            {
                Console.WriteLine("Address : " + this.address);
            }
            Console.WriteLine("Is Married : " + this.isMarried);
        }
        public string checkLogin()
        {
            if (this.userName == "Admin" && this.password == "123")
            {
                if (this.message == null)
                {
                    this.message = "You are Logged in as Admin!!";
                }

            }
            else if (this.userName.StartsWith("User") && this.password == "Pass123")
            {
                if (this.message == null)
                {
                    this.message = "You are Logged in as Normal User!!";
                }
            }
            else
            {
                if (this.message == null)
                {
                    this.message = "Invalid Login!!";
                }

            }
            return this.message;
        }




        // Age a=new Age(2010);


        //Student s1, s2;

        //s1= new Student();
        //s2= new Student();

        //Student.collegename = "Thiruvalluvar university";

        //s1.studentId = 1;
        //s1.studentname = "Eswaran";
        //s1.marks = 85;

        //s2.studentId = 2;
        //s2.studentname = "Aravindan";
        //s2.marks = 80;

        //Console.WriteLine("college name : "+Student.collegename);
        //Console.WriteLine();
        //Console.WriteLine("student id : "+s1.studentId);
        //Console.WriteLine("student name : "+s1.studentname);
        //Console.WriteLine("student marks : "+s1.marks);
        //Console.WriteLine();
        //Console.WriteLine("student id : " + s2.studentId);
        //Console.WriteLine("student name : " + s2.studentname);
        //Console.WriteLine("student marks : " + s2.marks);


        //Employee e1, e2;

        //e1 = new Employee();
        //e2 = new Employee();

        //Employee.companyName = "ChangePond Technologies";

        //e1.employeeName = "Eswaran";
        //e1.employeeAge = 21;
        //e1.employeeSalary = 28000;

        //e2.employeeName = "Sivalingam";
        //e2.employeeAge = 21;
        //e2.employeeSalary = 27000;

        //Console.WriteLine("Company name : "+Employee.companyName);
        //Console.WriteLine();
        //Console.WriteLine("Employee name : " + e1.employeeName);
        //Console.WriteLine("Employee age : " + e1.employeeAge);
        //Console.WriteLine("Employee salary : "+e1.employeeSalary);
        //Console.WriteLine();
        //Console.WriteLine("Employee name : " + e2.employeeName);
        //Console.WriteLine("Employee age : " + e2.employeeAge);
        //Console.WriteLine("Employee salary : " + e2.employeeSalary);





    }
    }

    
