using System;

namespace Lab_2
{
   public class CheckingAccount : Account
   {
      private int accountType;
      private decimal monthyFee;

      public CheckingAccount(int Id, decimal Balance, int TypeOfAccount) : base(Id, Balance)
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
               monthyFee = (3.95M);
               accountType = value;
            }
            else if (value == 2)
            {
               monthyFee = (6.95M);
               accountType = value;
            }
         }
      }

      public override decimal closeMonth()
      {
         if (balance < 1500)
         {
            return balance -= monthyFee;
         }
         else
         {
            return balance;
         }

      }

      public override string ToString() => $"Checking account {id} has a balance of {balance:C}";
   }
}
