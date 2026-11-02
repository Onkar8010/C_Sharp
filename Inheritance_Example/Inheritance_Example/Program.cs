using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal obj = new Animal();
            Console.WriteLine(obj.Eat());
            Console.WriteLine(obj.Bark());
/*
            Dog obj1 = new Dog();
            Console.WriteLine(obj1.Bark());

          */

        }
    }
}
