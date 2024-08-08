using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{

    class Student
    {

        public int studentId;
        public string studentname;
        public int marks;
        private int _age;
        public static string collegename;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value>=18 && value <=60)
                {
                    _age = value;
                }
            }
        }

    }
}
