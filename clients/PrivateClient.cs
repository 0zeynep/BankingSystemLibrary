using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.clients
{
    class PrivateClient : Client
    {
        protected readonly string firstName, lastName, email, country, password, phoneNumber;
        protected int age, amount;
        public PrivateClient(string firstName, string lastName, string email, string country, string password, string age, string phoneNumber, int amount)
        {
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
        public string Age
        {
            get { return age; }
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
