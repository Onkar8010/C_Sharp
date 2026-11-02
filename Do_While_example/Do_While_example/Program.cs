using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 0;
            do
            {
               
                Console.WriteLine( number);
                number++;


            } while (number <= 10);
        }
    }
}
