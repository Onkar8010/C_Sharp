using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter an operator (+, -, *, /) ");

            switch(Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Result: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {firstNumber * secondNumber}");
                    break;
                
                default:
                    Console.WriteLine("");
                    break;
            }

        }
    }
}
