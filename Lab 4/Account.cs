namespace Lab_2
{
   public abstract class Account
   {
      public int id { get; }
      public decimal balance { get; set; }

      public Account(int Id, decimal Balance)
      {
         id = Id;
         balance = Balance;
      }

      public decimal deposit(decimal amount)
      {
         return balance += amount;
      }

      public decimal withdraw(decimal amount)
      {
         return balance -= amount;
      }

      public abstract decimal closeMonth();

      public override string ToString() => $"Account {id} has a balance of {balance:C}";
   }
}