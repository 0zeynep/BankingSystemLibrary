using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.clients
{
    class PrivateClient : Client
    {
        protected readonly string firstName, lastName;
        protected int age;
        public PrivateClient(int clientId, string firstName, string lastName, string email, string country, string password, string age, string phoneNumber, int amount)
        {
            this.clientId = clientId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.country = country;
            this.password = password;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.amount = amount;
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string Age
        {
            get { return age; }
        }
    }
}
