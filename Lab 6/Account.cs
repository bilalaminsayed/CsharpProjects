using System;

namespace Lab_2
{
   [Serializable]

   public abstract class Account
   {
      public int id;
      public decimal balance;

      public Account(int Id, decimal Balance)
      {
         idOfAccount = Id;
         balanceOfAccount = Balance;
      }

      public int idOfAccount
      {
         get
         {
            return id;
         }
         set
         {
            if (value > 19M)
            {
               throw new AccountNumberLimitException("The maximum number of accounts has been exceeded.");
            }
            else
            {
               id = value;
            }
         }
      }

      public decimal balanceOfAccount
      {
         get
         {
            return balance;
         }
         set
         {
            if (value < 300M)
            {
               throw new InitialBalanceException("The initial deposit must be $300 or greater.");
            }
            else
            {
               balance = value;
            } 
         }
      } 

      public decimal deposit(decimal amount)
      {
         if (amount < 0)
         {
            throw new NegativeInputException("You cannot deposit a negative amount.");
         }
         else
         {
            return balance += amount;
         }
      }

      public decimal withdraw(decimal amount)
      {
         if (amount < 0)
         {
            throw new NegativeInputException("You cannot withdraw a negative amount.");
         }
         if ((balance - amount) < 0)
         {
            throw new NegativeResultException("This transaction will give the account a negative balance.");
         }
         else
         {
            return balance -= amount;
         }
      }
      

      public abstract decimal closeMonth();

      public override string ToString() => $"Account {id} has a balance of {balance:C}";
   }
}