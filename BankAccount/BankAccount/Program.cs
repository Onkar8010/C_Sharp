using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Bank  obj = new Bank();

            obj.DisplayName("Onkar shendkar");
            obj.CreditAmount(1000);
            obj.WithdrawAmount(500);
            obj.DisplayBalance(500);



        }
    }
}
