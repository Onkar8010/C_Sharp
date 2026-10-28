using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example_04
{
    internal class Student
    {

        public delegate void ShowDetails(string name, int age);


        public void StudentName(string name ,int age)
        {

            Console.WriteLine("name of student" + name);


        }

        public void StudentAge(string name ,int age)
        {
            Console.WriteLine("Age of student " + age);
        }


        public void Display()
        {
            ShowDetails del = new ShowDetails(StudentName);
            del("Onkar", 35);


            del = new ShowDetails(StudentAge);
            del("onkar",34);
        }
 
    }
}
