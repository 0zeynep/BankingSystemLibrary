using System;

namespace BankingLibrary
{
    public class Command
    {
        public decimal Payment { get; set; }
        public decimal Transfer { get; set; }
        public decimal ChangeOfInterestRate { get; set; }
        public decimal CalculateInterest { get; set; }
    }

    public class State
    {
        //https://www.sanfoundry.com/csharp-program-simple-interest/
        static void CalculateInterest()
        {
            int year;
            double princamt, rate, interest, total_amt;
            Console.Write("Enter The Loan Amount : ");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;
            total_amt = princamt + interest;
            Console.WriteLine("Total Amount : {0}", total_amt);
            Console.ReadLine();
        }

    }
}
namespace Visitor
{
    public List<Accounts> Accounts { get; set; } = new List<Accounts>();

    public List<Credits> Credidts { get; set; } = new List<Credidts>();

    public List<Loans> Loans { get; set; } = new List<Loans>();

    public List<Deposits> Deposits { get; set; } = new List<Deposits>();

    public List<Transactions> transactions { get; set; } = new List<Transactions>();

}
}