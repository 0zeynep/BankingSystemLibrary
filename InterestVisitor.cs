using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public class InterestVisitor : IVisitor
    {
        public void Visit(AbstractAccount abstractAccount)
        {
            Account account = abstractAccount as Account;
            
            account.Balance *= account.InterestRate;
        }
    }
}
