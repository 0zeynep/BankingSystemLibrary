using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.commands
{
    class CreateAccountCommand : Command
    {
        Bank myBank;
        Client clientCalling;
        public CreateAccountCommand(Bank myBank, Client clientCalling)
        {
            this.myBank = myBank;
            this.clientCalling = clientCalling;
        }
        public void Execute()
        {
            myBank.RegisterAccount(clientCalling);
        }
    }
}
