using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_example
{
    internal class Function
    {
          public void Cal (int a, int b ,char op)
        {
            if(op == '+')
            {
                Console.WriteLine("addition of two varible" +( a + b));
            }
            else if(op == '-')
            {
                Console.WriteLine("Subtraction = " + (a - b));
            }
        }

    }
}
