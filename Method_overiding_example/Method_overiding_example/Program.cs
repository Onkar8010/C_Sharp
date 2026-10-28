using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overiding_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodOveriding obj = new MethodOveriding();
            obj.Add(10, 20);
            obj.sub(10, 20);
            obj.Add(10, 20);


        }
    }
}
