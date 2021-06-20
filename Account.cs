using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public class Account
    {
        protected int accountId;
        protected float balance;
        Client ownerId;
        public Account(int accountId, Client ownerId, float balance)
        {
            this.accountId = accountId;
            this.ownerId = ownerId;
            this.balance = balance;
        }

        public int AccountId
        {
            get { return accountId; }
        }
        public Client OwnerId
        {
            get { return ownerId; }
        }
        public float Balance
        {
            get { return balance; }
            set { balance = Balance; }
        }



    }
}
