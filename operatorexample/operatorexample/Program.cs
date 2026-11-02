using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorexample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int amount;
            //int rate;
            // int total;

            /*

            Console.WriteLine("Enter a principal amount");
            int principalamount  = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter a rate of interest");
            int  rateofInterest  = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter a time in year");
            int time = Convert.ToInt16(Console.ReadLine());

            int simpleinterest = (principalamount * rateofInterest * time) / 100;

            Console.WriteLine("simple total interest" + simpleinterest);



            */


            /*

            string t1= "onkar";
            string t2= "shendkar";

            string result= t1 +" " +t2;

            Console.WriteLine(result);

            */


            //   4) assignment operator  =, !=, ==

            /*
            //  increment  and decrement  ++,--,


            int a = 5;
            a += 10;
            Console.WriteLine(a);

            int value = 10;
            Console.WriteLine(++value);
            Console.WriteLine(--value);
            */


            // terneary operator

            Console.Write("Enter the age");
            int age = Convert.ToInt16(Console.ReadLine());



            string output = (age >= 18) ? "you are elegibal for vote" : "you are not eligable for voting";


            Console.WriteLine(output);

        }
    }
}
