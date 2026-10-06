using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculate obj = new Calculate();
            obj.Cal(10, 20, '+');
            obj.Cal(10, 20, '-');
            obj.Cal(10, 20, '*');
            obj.Cal(10, 20, '/');

        }
    }
}
