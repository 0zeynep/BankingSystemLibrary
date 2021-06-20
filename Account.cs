using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public class Account : AbstractAccount
    {
        protected int accountId;
        protected double balance;
        protected double interestRate = 1.01;
        protected Client ownerId;
        public Account(int accountId, Client ownerId, double balance)
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
        public double Balance
        {
            get { return balance; }
            set { balance = Balance; }
        }        
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = InterestRate; }
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
