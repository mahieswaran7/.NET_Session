using OopsAdvance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvance
{
    internal class Employee : Person
    {
        private int _empId;
        public int Id
        {
            get { return _empId; }
            set
            {
                _empId = value;
            }
        }
        public double salary { get; set; }

        public override string displayDetails()
        {

            return "EmpID : " + _empId + " FullName : " + this.firstName + " " + this.lastName + "  Gender : " + this.gender + "  Salary : " + salary;
        }
    }

    //internal class Employee : Person
    //{
    //    private int _empId;
    //    public int Id
    //    {
    //        get { return _empId; }
    //        set
    //        {
    //            _empId = value;
    //        }
    //    }
    //    public double salary { get; set; }

    //    public Employee(string firstName, string lastName, string gender, int _empId, int salary) : base(firstName, lastName, gender)
    //    {
    //        this._empId = _empId;
    //        this.salary = salary;
    //    }

    //    public void displayEmployeeDetails()
    //    {
    //        Console.WriteLine("Employee Id :" + _empId);
    //        Console.WriteLine("Employee FirstName :" + base.firstName);
    //        Console.WriteLine("Employee LastName :" + base.lastName);
    //        Console.WriteLine("Employee Gender :" + base.gender);
    //        Console.WriteLine("Employee salary :" + salary);
    //    }
    //    public void displayDetails()
    //    {
    //        Console.WriteLine("Employee Id :" + this._empId);
    //        base.displayDetails();
    //        Console.WriteLine("Employee Salary : " + this.salary);
    //    }
    //}
}