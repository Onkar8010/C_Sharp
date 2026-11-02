using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
   public  abstract class Teacher
    {
        public abstract void TeacherName();
        
    }

    class Student  : Teacher

    {
        public override void TeacherName()
        {
            Console.WriteLine("Teacher Name: John Doe");
        } 
    }
}
