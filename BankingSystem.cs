using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    class BankingSystem
    {
        static BankingSystem myBankingSystem;
        protected BankingSystem()
        {
        }
        public static BankingSystem Instance()
        {
            if (myBankingSystem == null)
            {
                myBankingSystem = new BankingSystem();
            }
            return myBankingSystem;
        }
    }
}
