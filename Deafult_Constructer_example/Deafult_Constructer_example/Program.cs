using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deafult_Constructer_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(); // deafault constructor is called automatically when we create an object of the class.\

            Student obj1 = new Student(); // parametrised constructor is called automatically when we create an object of the class.

            obj1.Student1("OM", 20);

           
        }
    }
}
