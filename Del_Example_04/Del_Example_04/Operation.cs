using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del_Example_04
{
    internal class Operation
    {

        public delegate void MyDelegate(int a, int b);


        public void Add(int a, int b)
        {
            Console.WriteLine("addition of two number" + (a+b));
        }



        public void Display()
        {
            MyDelegate del = new MyDelegate(Add);

            del(10,20);
        }




    }
}
