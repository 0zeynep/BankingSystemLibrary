using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    class Client
    {
        protected string name;
        protected int clientId;
        protected List<Account> accountId;
        public Bank myBank;

        public Client(int clientId, string name)
        {
            this.clientId = clientId;
            this.name = name;
            this.accountId = new List<int>;
        }
        public int ClientId
        {
            get { return clientId; }
        }
        public string Name
        {
            get { return name; }
        }
        public void CreateAccount()
        {
            Account accountCreated = myBank.RegisterAccount(this);
            accountId.Add(accountCreated);
        }
        public void CloseAccount(Account accountToClose)
        {
            bool result = myBank.CloseAccount(accountToClose, this);
            if (result)
            {
                accountId.Remove(accountToClose);
            }
        }
        public void OrderTransfer(Account originAccountId, Account targetAccountId, float amountToTransfer)
        {
            myBank.TransferMoney(originAccountId, targetAccountId, amountToTransfer, this);
        }
    }
}
