using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class obj = new Class();


            obj.DisplayName();   // function calling no return type no parameter

            obj.DisplayName1("Onkar"); //parameter with no return type

            string name = obj.DisplayName2(); // return Type with  no parameter
            Console.WriteLine(name);

            string result  = obj.DisplayName3("Shendkar");
            Console.WriteLine(result);// with parameter with return type
           

        }
    }
}
