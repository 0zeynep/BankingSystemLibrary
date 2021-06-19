using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.clients
{
    class BusinessClient : Client 
    {
        protected readonly string name, email, country, password, phoneNumber;
        protected int amount;
        public BusinessClient(string name, string email, string password, string country,
                      string age, string phoneNumber, int amount)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.country = country;
            this.age = age;
            this.password = password;
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
        public string Age
        {
            get { return age; }
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
