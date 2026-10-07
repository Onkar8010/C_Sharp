using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_practice
{
    internal class Class
    {
        //no return type no parametr 
        public void DisplayName()
        {
            Console.WriteLine("onkar");
        }

         //parameter with no return type
        public void DisplayName1(string name)
        {
            Console.WriteLine(name); 
        }



        //return type with  no parameter

        public string DisplayName2()
        {
            return "onkar shendkar";
        }

        // with parameter with return type

        public string DisplayName3(string name)
        {
            return "Onkar";
        }

    }
}
