
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceManagement1;

namespace Bank_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the value ");
            int userPrincipalAmount = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Calculated interest rate for City bank  " + bank.CityBank(userPrincipalAmount));
            Console.WriteLine("calculate interest rate for Hdfc bank " + bank.Hdfc(userPrincipalAmount));
            Console.ReadLine();


        }
    }
}
