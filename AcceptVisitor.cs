using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public abstract class AcceptVisitor
    {
        public abstract void Accept(IVisitor visitor);
    }
}
