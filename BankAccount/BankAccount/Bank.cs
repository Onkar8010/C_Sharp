using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal partial class Bank
    {

        public void CreditAmount(int amount)
        {

            Console.WriteLine("credit amount = " + amount);

        }


    }


    internal partial class Bank
    {

        public void DebitAmount(int amount)
        {

            Console.WriteLine("Debit amount amount = " + amount);

        }
    }
}