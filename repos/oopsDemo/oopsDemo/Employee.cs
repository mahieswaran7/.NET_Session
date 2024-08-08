using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{

    class Employee
    {

        public string employeeName;
        public int age;
        public double salary;
        public string company;

        public Employee(string employeeName, int age)
        {
            this.employeeName = employeeName;
            this.age = age;
        }

        public Employee(string employeeName, int age, double salary)
        {
            this.employeeName = employeeName;
            this.age = age;
            this.salary = salary;
        }
        public Employee(string employeeName, int age, double salary, string company)
        {
            this.employeeName = employeeName;
            this.age = age;
            this.salary = salary;
            this.company = company;
        }
    }
}
