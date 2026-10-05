using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // explicit type casting    
            // go through this type

            double price =  125.56;
            int updatevalue = Convert.ToInt16(price);

            Console.WriteLine(updatevalue);


            /////////////////////////////
            ///
            // avoid this way
            string number = "12";
            int amount = int.Parse (number);




            /// implesit type casting
            /// 

            int a = 10;
            double b = a;


            int money = 23;
            string updatemoney =Convert.ToString (money);




        }
    }
}
