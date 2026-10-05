using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Logger Logger = new Logger();
            Logger.information("Start a new method.");
            int result =10 + 10;
            Console.WriteLine("The result is {result}");
            Logger.information("The result is {result}");
            Console.ReadLine();

        }
    }
}
