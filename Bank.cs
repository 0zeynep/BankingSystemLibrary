using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    class Bank
    {
        private List<Client> Clients;
        private List<Account> Accounts;
        
        public Account RegisterAccount(Client clientCalling)
        {
            Account accountCreated = new Account(1, clientCalling, 0);
            Accounts.Add(accountCreated);
            return accountCreated;
        }        
        public bool CloseAccount(Account accountToClose, Client clientCalling)
        {
            Accounts.Remove(accountToClose);
            return true;
        }
        public void TransferMoney(Account originAccountId, Account targetAccountId, float amountToTransfer, Client clientCalling)
        {
            if (true)
            {
                originAccountId.Balance = originAccountId.Balance - amountToTransfer;
                targetAccountId.Balance = targetAccountId.Balance + amountToTransfer;

            }
        }
    }
}
