using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Enter a number");
            int first =Convert.ToInt16 (Console.ReadLine());


            Console.WriteLine("Enter a number");
            int second = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("addition of two number= "+(first + second));

            Console.WriteLine("sub of two number= "+(first - second));

            Console.WriteLine("mul of two number= "+( first * second));

            Console.WriteLine("div of two number= "+( first / second));

            Console.ReadLine();

            */

            //  Another code



            Console.WriteLine("Enter total Unit Consumed");
            double unit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter price per unit ");
            double price = Convert.ToDouble(Console.ReadLine());

            double bill = unit * price;

            Console.WriteLine("total electricty bill=" + bill);


        }
    }
}
