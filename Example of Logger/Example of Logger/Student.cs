using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Logger
{
    internal class Student
    {

       public static void info(string message)
        {
            Console.WriteLine("INFO:+ {message}");
        }
        public static void warning(string message)  
        {
            Console.WriteLine($"WARNING: {message}");
        }
        public static void error(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }
    }
}
