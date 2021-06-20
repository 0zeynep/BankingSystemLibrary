using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.commands
{
    class CloseAccountCommand
    {
        Account accountToClose;
        Bank myBank;
        Client clientCalling;
        public CloseAccountCommand(Account accountToClose, Bank myBank, Client clientCalling)
        {
            this.accountToClose = accountToClose;
            this.myBank = myBank;
            this.clientCalling = clientCalling;
        }
        public void Execute()
        {
            myBank.CloseAccount(accountToClose, clientCalling);
        }
    }
}
