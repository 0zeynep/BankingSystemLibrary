using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public abstract class AccountDecorator : AbstractAccount
    {
        protected Account account;
        // Constructor
        public AccountDecorator(Account account)
        {
            this.account = account;
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
