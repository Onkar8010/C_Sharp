using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmmentoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mark");
            int mark = Convert.ToInt16(Console.ReadLine());

            if (mark > 20 && mark <= 30)
            {
                Console.WriteLine("pass with c grade");
            }
            else if (mark > 35 && mark <= 50)
            {
                Console.WriteLine("you are passed with b grade");
            }
            else if (mark > 51 && mark <= 70)
            Console.WriteLine("you are passed with a grade");

        }
    }
}
