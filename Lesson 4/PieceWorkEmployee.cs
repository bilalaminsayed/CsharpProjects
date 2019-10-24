using System;

public class PieceWorkEmployee : Employee
{
   private decimal wagePerPiece;
   private int pieces;

   // five-parameter constructor
   public PieceWorkEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal wagePer,
      int piecesProduced)
      : base(firstName, lastName, socialSecurityNumber)
   {
      WagePerPiece = wagePer;
      Pieces = piecesProduced;
   }

   public decimal WagePerPiece
   {
      get
      {
         return wagePerPiece;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(WagePerPiece)} must be >= 0");
         }

         wagePerPiece = value;
      }
   }

   public int Pieces
   {
      get
      {
         return pieces;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Pieces)} must be >= 0");
         }

         pieces = value;
      }
   }

   public override decimal Earnings()
   {
      return WagePerPiece * Pieces;
   }

   // return string representation of HourlyEmployee object
   public override string ToString() =>
      $"piece work employee: {base.ToString()}\n" +
      $"wage per piece: {WagePerPiece:C}\npieces produced: {Pieces}";
}


