using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example_03
{
    internal class Operation
    {

        public delegate void MyDel(int a, int b);




        public void add(int a, int b) 
        {
            Console.WriteLine("Addition of two no = " + (a+b));
        }


        public void sub(int a, int b)
        {
            Console.WriteLine("substraction  of two no = " + (a - b));
        }


        public void mul(int a, int b)
        {
            Console.WriteLine("multiplication of two no = " + (a * b));
        }

        public void div(int a, int b)
        {
            Console.WriteLine("division of two no = " + (a / b));
        }



        public void Display()
        {

            MyDel del = new MyDel(add);
            del(10, 20);

            del = new  MyDel(sub);
            del(30, 20);
                        
                        
            del = new MyDel(mul);
            del(58, 65);
                        
                        
            del = new MyDel(div);
            del(45,65);




        }


    }
}
