using OopsAdvance;

class Program
{
    private static void Main(string[] args)
    {
        BMW BW = new BMW();
        BW.brand = "BMW";
        BW.model = "5-Series";
        BW.specialfeatures = "Massage Seats";
        Console.WriteLine(BW.getCarDetails());

        Mercedez m = new Mercedez();
        m.brand = "Merecedez";
        m.model = "M-15";
        m.mileage = 13;
        Console.WriteLine(m.getCarDetails());


        Employee e = new Employee();
        e.Id = 100;
        e.firstName = "Eswaran";
        e.lastName = "Arumugam";
        e.gender = "Male";
        e.salary = 25000;
        Console.WriteLine(e.displayDetails());






        // Console.WriteLine("INHERITANCE CONCEPT !!!");

        //Person p = new Person();
        //p.firstName = "Eswaran";
        //p.lastName = "Arumugam";
        //p.gender = "Male";

        //Console.WriteLine("\n");
        //Console.WriteLine("Person Details :");
        //Console.WriteLine("\n");
        //Console.WriteLine("Person Full Name : " + p.firstName + " " + p.lastName);
        //Console.WriteLine("Person Gender : " + p.gender);
        //Console.WriteLine("\n");

        // Student s = new Student("Eswaran","Arumugam","male",101,95);

        //s.studentId = 1;
        //s.firstName = "Eashwar";
        //s.lastName = "A";
        //s.marks = 100;
        //s.gender = "Male";

        //Console.WriteLine("\n");
        //Console.WriteLine("Student Details :");
        //Console.WriteLine("\n");
        //s.displayDetails();


        //Console.WriteLine("Student Id : " + s.studentId);
        //Console.WriteLine("Student Full Name : " + s.firstName + " " + s.lastName);
        //Console.WriteLine("Student Mark : " + s.marks);
        //Console.WriteLine("Student Gender : " + s.gender);
        //Console.WriteLine("\n");

        // Employee e = new Employee("Dharnesh", "Rajamanickam", "Female", 100, 5000);

        //e.Id = 100;
        //e.firstName = "Eashwar";
        //e.lastName = "A";

        //e.gender = "Male";
        //e.salary = 8786798;

        //Console.WriteLine("\n");
        //Console.WriteLine("Employee Details :");
        //Console.WriteLine("\n");
        //e.displayDetails();


        //e.displayEmployeeDetails();
        //Console.WriteLine("Employee Id : " + e.Id);
        //Console.WriteLine("Employee Full Name : " + e.firstName + " " + e.lastName);

        //Console.WriteLine("Employee Gender : " + e.gender);
        //Console.WriteLine("Employee Salary : " + e.salary);
        //Console.WriteLine("\n");
    }
}

