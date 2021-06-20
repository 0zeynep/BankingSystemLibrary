using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public interface IVisitor
    {
        void Visit(AbstractAccount abstractAccount);
    }
}
