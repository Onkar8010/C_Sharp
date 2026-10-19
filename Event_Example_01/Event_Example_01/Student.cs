using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example_01
{
    internal class Student
    {

        public delegate void MyDelegate();

        public event MyDelegate pass;


        public void CheckResult(int marks)
        {
            if(marks >= 50)
            {
                pass?.Invoke();
            }

            else
            {
                Console.WriteLine("Student Failed");
            }


        }

        public void Display() 
        {
            Console.WriteLine("Student is Passed");
        
        }




    }
}
