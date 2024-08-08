using System.Security.Cryptography;

namespace OopsDemo;


//class Age
//{
//    public readonly int _year;

//    public Age(int year)
//    {
//        this._year = year;
//        Console.WriteLine(this._year);
//    }
//}



class Program
{
    private static void Main(string[] args)
    {
        //Employee e1, e2, e3;
        //e1 = new Employee("Siva", 21);
        //Console.WriteLine("Employee Name :" + e1.employeeName + " Employee Age :" + e1.age);
        //Console.WriteLine();
        //e2 = new Employee("Eashwar", 21, 25000.0);
        //Console.WriteLine("Employee Name :" + e2.employeeName + " Employee Age :" + e2.age + " Employee Salary : " + e2.salary);
        //Console.WriteLine();
        //e3 = new Employee("Dinesh", 21, 20000.0, "ChangePond");
        //Console.WriteLine("Employee Name :" + e3.employeeName + " Employee Age :" + e3.age + " Employee Salary : " + e3.salary + "  Company Name : " + e3.company);

        //Console.WriteLine();


        Student s1, s2;
        s1 = new Student() { studentId = 1, studentname = "Eswaran" };
        s1.Age = 21;
        Console.WriteLine("Student Id :" + s1.studentId);
        Console.WriteLine("Name :" + s1.studentname);
        Console.WriteLine("marks :" + s1.marks);
        Console.WriteLine("Age:" + s1.Age);




        //User u1, u2, u3, u4;

        //for (int i = 0; i < 3; i++)
        //{
        //    Console.Write("enter username : ");
        //    string username = Console.ReadLine();
        //    Console.Write("Enter password : ");
        //    string password = Console.ReadLine();
        //    u1 = new User(username, password);
        //    string result = u1.checkLogin();
        //    u1.getDetails();
        //    Console.WriteLine(result);

        //    Console.WriteLine("----------------------------");
        //    Console.WriteLine();



        //    u2 = new User("Siva", "Pass234", "Guest User");
        //    u2.getDetails();
        //    result = u2.checkLogin();
        //    Console.WriteLine(result);


        //    Console.WriteLine("----------------------------");
        //    Console.WriteLine();


        //    u3 = new User("Eashwar", "Pass456", "Special User", "Chennai");
        //    u3.getDetails();
        //    result = u3.checkLogin();
        //    Console.WriteLine(result);


        //    Console.WriteLine("----------------------------");
        //    Console.WriteLine();


        //    u4 = new User("Dharnesh", "Pass789", "Normal User", "Madhurai", false);
        //    u4.getDetails();
        //    result = u4.checkLogin();
        //    Console.WriteLine(result);


        //    Console.WriteLine("----------------------------");
        //    Console.WriteLine();


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
        //e2.employeeAge = 20;
        //e2.employeeSalary = 24000;

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
