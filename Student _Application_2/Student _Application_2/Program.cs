using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Application;

namespace Student__Application_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.StudentName("onkar");
            obj.StudentLastName("shendkar");
            obj.StudentGender("Male");
            obj.StudentAge(22);
            obj.StudentGrade("A+");
        }
    }
}
