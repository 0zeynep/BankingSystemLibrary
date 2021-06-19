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
}