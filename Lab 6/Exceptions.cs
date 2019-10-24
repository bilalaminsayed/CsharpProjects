using System;
using System.Runtime.Serialization;

namespace Lab_2
{
   [Serializable]
   internal class InitialBalanceException : Exception
   {
      public InitialBalanceException()
      {
      }

      public InitialBalanceException(string message) : base(message)
      {
      }

      public InitialBalanceException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }

   internal class AccountNumberLimitException : Exception
   {
      public AccountNumberLimitException()
      {
      }

      public AccountNumberLimitException(string message) : base(message)
      {
      }

      public AccountNumberLimitException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }

   internal class NegativeResultException : Exception
   {
      public NegativeResultException()
      {
      }

      public NegativeResultException(string message) : base(message)
      {
      }

      public NegativeResultException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }

   internal class NegativeInputException : Exception
   {
      public NegativeInputException()
      {
      }

      public NegativeInputException(string message) : base(message)
      {
      }

      public NegativeInputException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }

   internal class EmptyFieldException : Exception
   {
      public EmptyFieldException()
      {
      }

      public EmptyFieldException(string message) : base(message)
      {
      }

      public EmptyFieldException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }

   internal class AccountDoesNotExistException : Exception
   {
      public AccountDoesNotExistException()
      {
      }

      public AccountDoesNotExistException(string message) : base(message)
      {
      }

      public AccountDoesNotExistException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }
}
