using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public abstract class AccountDecorator : Account
    {
        protected Account account;
        // Constructor
        public AccountDecorator(Account account)
        {
            this.account = account;
        }

    }
}
