using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Function_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cal obj= new Cal();
            obj.calculate(10, 20, '+');
            obj.calculate(20, 10, '-');
        }
}
