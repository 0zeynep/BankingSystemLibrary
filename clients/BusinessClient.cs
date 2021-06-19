using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.clients
{
    class BusinessClient : Client 
    {
        protected readonly string name;
        public BusinessClient(int clientId, string name, string email, string country, string password, string phoneNumber, int amount)
        {
            this.clientId = clientId;
            this.name = name;
            this.email = email;
            this.country = country;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.amount = amount;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
