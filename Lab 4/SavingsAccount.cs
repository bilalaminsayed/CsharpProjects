using System;

namespace Lab_2
{
   public class SavingsAccount : Account
   {
      private int accountType;
      private decimal interestRate;

      public SavingsAccount(int Id, decimal Balance, int TypeOfAccount): base(Id, Balance)
      {
         AccountType = TypeOfAccount;
      }

      public int AccountType
      {
         get
         {
            return accountType;
         }
         set
         {
            if (value < 0)
            {
               throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(AccountType)} must be >= 0");
            }
            else if (value == 1)
            {
               interestRate = (.015M / 12);
               accountType = value;
            }
            else if (value == 2)
            {
               interestRate = (.02M / 12);
               accountType = value;
            }
         }
      }

      public override decimal closeMonth()
      {
         if (balance >= 2500)
         {
            return balance = balance + (balance * interestRate);
         }
         else
         {
            return balance;
         }

      }

      public override string ToString() => $"Savings account {id} has a balance of {balance:C}";
   }
}