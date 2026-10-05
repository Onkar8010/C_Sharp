using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    public static  class Logger
    {
        public static void information(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }

        public  static void warning(string message)
        {
            Console.WriteLine($"[WARNING] {message}");
        }
        public  static void error(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
        }
    }
}
