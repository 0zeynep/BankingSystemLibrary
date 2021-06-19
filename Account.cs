using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    abstract class Account
    {
        protected int accountId, ownerId;
        protected float balance;

        public int AccountId
        {
            get { return accountId; }
        }
        public int OwnerId
        {
            get { return OwnerId; }
        }        
        public float Balance
        {
            get { return balance; }
        }

    }
}
