using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_Example2
{
    internal class Calculate
    {


        public void Cal(int a, int b, char op)
        {
            if (op == '+')
            {
                Console.WriteLine("addition of" + (a + b));
            }
            else if (op == '-')
            {
                Console.WriteLine("Subtraction = " + (a - b));
            }

            else if (op == '*')
            {
                Console.WriteLine("multplication = " + (a * b));
            }
            else if (op == '/')
            {
                Console.WriteLine("Division = " + (a / b));
            }



        }




















    }
}
