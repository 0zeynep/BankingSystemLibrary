using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.decorators
{
    class Shareable : AccountDecorator
    {
        protected readonly List<Client> coowners = new List<Client>();
        public Shareable(Account account) : base(account)
        {
        }
        public void ShareAccountWith(Client coowner)
        {
            coowners.Add(coowner);
        }
        public void RemoveAccessToAccount(Client coowner)
        {
            coowners.Remove(coowner);
        }
        public void ListCoowners(Account account)
        {
            Console.WriteLine("Owner: " + this.OwnerId.ClientId);
            foreach (Client coowner in coowners)
            {
                Console.WriteLine("Coowner: " + coowner.ClientId);
            }
        }
    }
}
