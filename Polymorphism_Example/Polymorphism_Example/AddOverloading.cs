using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    internal  class AddOverloading
    {

        public void Add(int a, int b)
        {

            Console.WriteLine($"sum +{ a+b}");
        }

        public  void Add(int a ,int b, int c)
        {
            Console.WriteLine($"addition of three +{a+b+c}");
        }





    }
}
