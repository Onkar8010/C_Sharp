using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example_02
{
    internal class Addition
    {

        public delegate void MyDelegate(int a, int b);


        public void Add(int a ,int b)
        {
            Console.WriteLine("addition = "+(a+b));

        }


        public void Display() 
        {

            MyDelegate del = new MyDelegate(Add);

            del(10, 20);



        }



    }
}
