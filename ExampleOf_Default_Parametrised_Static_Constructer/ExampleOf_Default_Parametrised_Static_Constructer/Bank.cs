using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOf_Default_Parametrised_Static_Constructer
{
    internal class Bank
    {

        /*

        //parametrised constructor
         public Bank()
        {
            Console.WriteLine("Baroda Bank");

        }

        */



        /*

        //Parametrised constructor

        public void Bank1(string name, string brabch,int AccountNo)
        {
                        Console.WriteLine("Bank Name: " + name);
            Console.WriteLine("Branch: " + brabch);
            Console.WriteLine("AccountNo: "+ AccountNo);
        }
        */



        //Static constructor

        public static void DisplayName()
        {
            Console.WriteLine("Baroda Bank");
        }

        public static void IfscCode()
        {
            Console.WriteLine("IFSC Code: BARB0BHANDE");

        }

        public static void AccountNo()
        {
            Console.WriteLine("Account No: 1234567890");
        }



    }

} 

