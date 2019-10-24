using System;


public class BonusCommissionEmployee : CommissionEmployee
{
   private decimal salesGoal;

   public BonusCommissionEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal grossSales,
      decimal commissionRate, decimal salesGoal)
      : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
   {
      SalesGoal = salesGoal;
   }

   public decimal SalesGoal
   {
      get
      {
         return salesGoal;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(SalesGoal)} must be >= 0");
         }

         salesGoal = value;
      }
   }

   public override decimal Earnings()
   {
      if (GrossSales > salesGoal)
      {
         decimal bonus = 1.5M;
         return (CommissionRate * salesGoal) + ((bonus * CommissionRate) * (GrossSales - salesGoal));
      }
      else
      {
         return GrossSales * CommissionRate;
      }
   }

   public override string ToString() =>
      $"bonusCommission commission employee: {FirstName} {LastName}\n" +
      $"social security number: {SocialSecurityNumber}\n" +
      $"gross sales: {GrossSales:C}\n" +
      $"commission rate: {CommissionRate:F2}\n" +
      $"sales goal: {SalesGoal:F2}";
}

