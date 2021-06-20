using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public abstract class AbstractAccount
    {
        public abstract void Accept(IVisitor visitor);

    }
}
