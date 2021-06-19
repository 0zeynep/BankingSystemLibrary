using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    interface Operation
    {
        void execute();
        void assignCommand();
    }
}
