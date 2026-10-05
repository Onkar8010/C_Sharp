using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Logger
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Student.info("This is an info message.");
            Student.warning("This is a warning message.");
            Student.error("This is an error message.");

        }
    }
}
