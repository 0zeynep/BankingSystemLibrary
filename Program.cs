using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankingSystem myBankingSystem = BankingSystem.Instance();

            Console.ReadKey();
        }
    }
}
