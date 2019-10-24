using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
   class Account
   {
      public int AccountId { get; set; }
      public decimal Balance { get; set; }

      public Account(int accountID, decimal balance)
      {
         AccountId = accountID;
         Balance = balance;
      }

      public void Deposit(decimal amount)
      {
         Balance += amount;
      }

      public void Withdraw(decimal amount)
      {
         Balance -= amount;
      }

      public override string ToString()
      {
         return AccountId + " " + Balance;
      }
   }
}
