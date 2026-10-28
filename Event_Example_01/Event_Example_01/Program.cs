using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Example_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            student.CheckResult(50);
            student.pass += student.Display;
           // student.Display();


        }
    }
}
