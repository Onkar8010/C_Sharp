using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if 
            //if_else
            //
             
            Console.WriteLine("Enter your mark: ");
            int mark =Convert.ToInt16( Console.ReadLine());
            if (mark <= 20)
            {
                Console.WriteLine("Fail.");
            }
            else if(mark >=40 && mark < 69)
            {
                Console.WriteLine("Pass.");
            }
            else if (mark >= 60 && mark < 79)
            {
                Console.WriteLine("Exellent.");
            }
            else if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("Oustanding.");
            }
           
        }
    }
}
