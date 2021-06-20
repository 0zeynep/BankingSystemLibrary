using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    public interface Command
    {
        public abstract void Execute();
    }
}
