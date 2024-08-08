//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OopsAdvance
//{
//    internal class Student:Person
//    {

//        public int studentId { get; set; }
//        public int marks { get; set; }
//        public Student(string firstName, string lastName, string gender, int studentId, int marks) : base(firstName, lastName, gender)
//        {
//            this.studentId = studentId;
//            this.marks = marks;
//        }

//        public void DisplayStudentDetails()
//        {
//            Console.WriteLine("Student FirstName:" + base.firstName);
//            Console.WriteLine("Student LastName:" + base.lastName);
//            Console.WriteLine("Student Gender:" + base.gender);
//            Console.WriteLine("Student Maks:" + marks);
//            Console.WriteLine("Student Id:" + studentId);

//        }

//        public void displayDetails()
//        {
//           // base.displayDetails();
//            Console.WriteLine("Student Id :" + this.studentId);
//            Console.WriteLine("Student Marks : " + this.marks);
//        }
//    }
//}
