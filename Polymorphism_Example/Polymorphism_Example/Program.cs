using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AddOverloading obj = new AddOverloading();

            obj.Add(10, 20);
            obj.Add(10, 20,30);



        }
    }
}
