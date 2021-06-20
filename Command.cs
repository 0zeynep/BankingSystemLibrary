using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    interface Command
    {
        public abstract void Execute();
    }
}
