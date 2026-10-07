using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_noretun_noparameter
{
    internal class Calculate
    {
        // no return type and no parameter function
        public void DisplayName()
        {

            Console.WriteLine("Onkar shendkar");
        
        }

        //parameterized function with no return type

        public void DisplayName1(string name)
        { 
             Console.WriteLine(name);
        }


        // return type function with no parameter

        public string GetName()
        {
            return "Onkar shendkar";
        }


        // with parameter with retur type

        public string Display(string name)
        {
            return "onkar shendkar";

        }


    }
}
