using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practices
{
    internal class Student
    {
        public void StudentName(string name)
        {
        
          Console.WriteLine("student name " + name);

        }
        public void StudentLastName(string lastName)
        { 
           Console.WriteLine("student last name " + lastName);

        }
        public void StudentGender(string gender)
        {
            Console.WriteLine("student gender " + gender);
        }
        public void StudentAge(int age)
        {
            Console.WriteLine("student age " + age);
        }
        public void StudentMark(int mark)
        {

            Console.WriteLine("student mark " + mark);
        
        }
        public void StudentResult(int mark)
        {
            if (mark >= 40) 
            { 
            
              Console.WriteLine(" pass ");
            }


            else
            {
                Console.WriteLine(" fail ");
            }
        
        }




    }
}
