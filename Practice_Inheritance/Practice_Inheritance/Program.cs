using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Teacher obj = new Teacher();
            Console.WriteLine(obj.StudentName("onkar"));
            Console.WriteLine(obj.StudentAge(45));
            Console.WriteLine(obj.Attandance(4545));




          

        }
    }
}
