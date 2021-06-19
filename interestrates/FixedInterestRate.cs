using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemLibrary.interestrates
{
    class FixedInterestRate
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
