using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Application
{
    public class Student
    {

        public void  StudentName(string name) 
        { 
            Console.WriteLine("Student Name: " + name);
        }

        public void StudentLastName(string lastName)
        {
            Console.WriteLine("Student Last Name: " + lastName);
        }

        public void StudentGender(string gender)
        {
            Console.WriteLine("Student Gender: " + gender);
        }
        public void StudentAge(int age)
        {
            Console.WriteLine("Student Age: " + age);
        }
        public void StudentGrade(string grade)
        {
            Console.WriteLine("Student Grade: " + grade);
        }

    }
}
