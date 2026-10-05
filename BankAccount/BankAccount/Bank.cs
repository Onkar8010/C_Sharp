using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Bank
    {
        public void  DisplayName(string name)
        {
            Console.WriteLine("Account holder name: ="+ name);

        }

        public void CreditAmount(int amount)
        {

            Console.WriteLine("credit amount = "+amount);

        }

        public void WithdrawAmount(int amount)
        {
            Console.WriteLine("withdraw amount =" + amount);
        }

        public void DisplayBalance(int balance)
        {
            Console.WriteLine("balance amount =" + balance);

        }


    }
}
