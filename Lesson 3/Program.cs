using System;

public class BasePlusCommissionEmployeeTest
{
   static void Main()
   {
      // instantiate BasePlusCommissionEmployee object
      var employee = new BonusCommissionEmployee("Bob", "Lewis",
         "333-33-3333", 5000.00M, .04M, 5000.00M);

      // display BasePlusCommissionEmployee's data
      Console.WriteLine(
         "Employee information obtained by properties and methods: \n");
      Console.WriteLine($"First name is {employee.FirstName}");
      Console.WriteLine($"Last name is {employee.LastName}");
      Console.WriteLine(
         $"Social security number is {employee.SocialSecurityNumber}");
      Console.WriteLine($"Gross sales are {employee.GrossSales:C}");
      Console.WriteLine(
         $"Commission rate is {employee.CommissionRate:F2}");
      Console.WriteLine($"Earnings are {employee.Earnings():C}");
      Console.WriteLine($"Sales goal is {employee.SalesGoal:C}");

      employee.GrossSales = 7000.00M; // set base salary

      Console.WriteLine(
         "\nUpdated employee information obtained by ToString:\n");
      Console.WriteLine(employee);
      Console.WriteLine($"earnings: {employee.Earnings():C}");
   }
}