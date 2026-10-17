using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructer_Example_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student();


            Console.WriteLine("Total Balance of Bank " + student.TotalBal());

        }
    }
}
