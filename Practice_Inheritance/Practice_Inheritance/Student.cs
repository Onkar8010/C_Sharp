using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    public class Student
    {
        public string StudentName(string name)
        {
            return name;
        }

        public int StudentAge(int age)
        {
            return age;
        }
    }


    public class Teacher :Student
    {
       
     public double Attandance(double attan)
        {
            return attan;
        }

    
    
    }

}
