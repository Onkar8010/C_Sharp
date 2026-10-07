using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_noretun_noparameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            //
            cal.DisplayName();
            //
            cal.DisplayName1("onkar");

            // with return type no parameter
            string name = cal.GetName();

            Console.WriteLine("name" + name);

            //
            cal.Display("onkar");

        }






    }
}
