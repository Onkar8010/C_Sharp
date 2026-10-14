using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Deafult_Constructer_example
{
    internal class Student
    {


        public Student()  /// 
        {
                Console.WriteLine("This is a default constructor.");
         }

        public void Student1(string name, int age)
        {

            Console.WriteLine("My name is = " + name );
            Console.WriteLine( " years old = "+ age );


        }
    }
    
}
