using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inhertance_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Devloper obj = new Devloper();
            Console.WriteLine(obj.PersonName("onkar"));
            Console.WriteLine(obj.EmployeeId(45));
            Console.WriteLine(obj.DevloperWork("Deloper write the code"));
           
        }
    }
}
