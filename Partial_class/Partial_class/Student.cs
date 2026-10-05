using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
    internal partial class Student
    {

        public void StudentName(string name)
        {
            Console.WriteLine("name of student = " + name);

        }
        public void StudentAge(int age)
        {
            Console.WriteLine($"Student age:" + age);

        }


    }



        internal partial class Student

        {
            public void StudentRoll(int roll)
            {
                Console.WriteLine("student roll no" + roll);

            }

            public void StudentGender(string gender)
            {
                Console.WriteLine("student gender " + gender);

            }

        }

    


}
