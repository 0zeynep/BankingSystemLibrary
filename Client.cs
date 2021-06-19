using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary
{
    abstract class Client
    {
        protected string email, country, password, phoneNumber;
        protected int clientId, amount;

        public int ClientId
        {
            get { return ClientId; }
        }
        public string Email
        {
            get { return email; }
        }
        public string Country
        {
            get { return country; }
        }
        public string Password
        {
            get { return password; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }
    }
}
