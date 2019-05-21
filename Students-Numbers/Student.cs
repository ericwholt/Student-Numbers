using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Numbers
{
    class Student
    {
        public string Name { get { return name; } }
        public int Age { get { return age; } }

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This Student is named: " + Name);
            Console.WriteLine("Their Age is " + Age);
        }
    }
}
