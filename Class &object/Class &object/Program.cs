using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate calculate = new calculate();

            Console.WriteLine("Enter a  value");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b  value");
            int b = Convert.ToInt32(Console.ReadLine());

            calculate.Addition(a, b);
            calculate.substraction(a, b);


            calculate.multplication(a, b);


            calculate.division(a, b);




        }
    }
}
