using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.commands
{
    class TransferCommand : Command
    {
        Account originAccountId, targetAccountId;
        float amountToTransfer;
        Bank myBank;
        Client clientCalling;
        public TransferCommand(Account originAccountId, Account targetAccountId, float amountToTransfer, Bank myBank, Client clientCalling)
        {
            this.originAccountId = originAccountId;
            this.targetAccountId = targetAccountId;
            this.amountToTransfer = amountToTransfer;
            this.myBank = myBank;
            this.clientCalling = clientCalling;
        }
        public void Execute()
        {
            myBank.TransferMoney(originAccountId, targetAccountId, amountToTransfer, clientCalling);
        }
    }

}
