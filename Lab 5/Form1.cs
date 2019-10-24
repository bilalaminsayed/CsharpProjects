using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Lab_2
{
   public partial class bankForm : Form
   {
      public bankForm()
      {
         InitializeComponent();
      }

      List<Account> accounts = new List<Account>(19);

      private void CreateAccountButton_Click_1(object sender, EventArgs e)
      {

         try
         {
            messageLabel.Text = "";
            errorLabel.Text = "";

            if (string.IsNullOrWhiteSpace(amountTextBox.Text))
            {
               MessageBox.Show("Please enter an amount.");
            }
            else if (checkingsRadioButton.Checked == false && savingsRadioButton.Checked == false)
            {
               MessageBox.Show("Please choose account type.");
            }
            else if (collegeStudentCheckBox.Checked == true && seniorCitizenCheckBox.Checked == true)
            {
               MessageBox.Show("Please check either Student or Senior or none, not both.");
            }
            else
            {
               if (savingsRadioButton.Checked == true)
               {
                  if (collegeStudentCheckBox.Checked == true)
                  {
                     var account = new SavingsAccount(Convert.ToInt32(accounts.Count + 1), Convert.ToDecimal(amountTextBox.Text), -1);
                     accounts.Add(account);
                     messageLabel.Text = "Savings Account #" + account.id + " opened with a balance of $" + account.balance;
                  }
                  if (seniorCitizenCheckBox.Checked == true)
                  {
                     var account = new SavingsAccount(Convert.ToInt32(accounts.Count + 1), Convert.ToDecimal(amountTextBox.Text), 2);
                     accounts.Add(account);
                     messageLabel.Text = "Savings Account #" + account.id + " opened with a balance of $" + account.balance;
                  }
                  if (collegeStudentCheckBox.Checked == false && seniorCitizenCheckBox.Checked == false)
                  {
                     var account = new SavingsAccount(Convert.ToInt32(accounts.Count + 1), Convert.ToDecimal(amountTextBox.Text), 1);
                     accounts.Add(account);
                     messageLabel.Text = "Savings Account #" + account.id + " opened with a balance of $" + account.balance;
                  }
               }
               if (checkingsRadioButton.Checked == true)
               {
                  if (collegeStudentCheckBox.Checked == true)
                  {
                     var account = new CheckingAccount(Convert.ToInt32(accounts.Count + 1), Convert.ToDecimal(amountTextBox.Text), 1);
                     accounts.Add(account);
                     messageLabel.Text = "Checking Account #" + account.id + " opened with a balance of $" + account.balance;
                  }
                  if (seniorCitizenCheckBox.Checked == true)
                  {
                     var account = new CheckingAccount(Convert.ToInt32(accounts.Count + 1), Convert.ToDecimal(amountTextBox.Text), 2);
                     accounts.Add(account);
                     messageLabel.Text = "Checking Account #" + account.id + " opened with a balance of $" + account.balance;
                  }
                  if (collegeStudentCheckBox.Checked == false && seniorCitizenCheckBox.Checked == false)
                  {
                     var account = new CheckingAccount(Convert.ToInt32(accounts.Count + 1), Convert.ToDecimal(amountTextBox.Text), 2);
                     accounts.Add(account);
                     messageLabel.Text = "Checking Account #" + account.id + " opened with a balance of $" + account.balance;
                  }
               }
            }
         }
         catch (Exception ex)
         {
            if (ex is FormatException)
            {
               errorLabel.Text = "Invalid format in the Amount Field. Please Correct";
            }
            else
            {
               errorLabel.Text = ex.Message;
            } 
         }
      }

      private void ExecuteButton_Click(object sender, EventArgs e)
      {
         try
         {
            messageLabel.Text = "";
            errorLabel.Text = "";

            if (String.IsNullOrEmpty(accountIDTextBox.Text))
            {
               throw new EmptyFieldException("No account selected.");
            }

            var selectedAccount =
               from account in accounts
               where account.id == Convert.ToInt32(accountIDTextBox.Text)
               select account;
             
            if (!selectedAccount.Any())
            {
               throw new AccountDoesNotExistException("There is no account with that id. Please correct.");
            }

               if (depositRadioButton.Checked == true)
            {
               foreach (var account in selectedAccount)
               {
                  account.deposit(Convert.ToDecimal(amountTextBox.Text));
                  messageLabel.Text = ("$" + Convert.ToString(amountTextBox.Text) + " deposited into Account #" + Convert.ToString(account.id));
               }
            }
            if (withdrawRadioButton.Checked == true)
            {
               foreach (var account in selectedAccount)
               {
                  account.withdraw(Convert.ToDecimal(amountTextBox.Text));
                  messageLabel.Text = ("$" + Convert.ToString(amountTextBox.Text) + " withdrawn from Account #" + Convert.ToString(account.id));
               }
            }
            if (balanceRadioButton.Checked == true)
            {
               foreach (var account in selectedAccount)
               {
                  messageLabel.Text = account.ToString();
               }
            } 
         }
         catch (Exception ex)
         {
            if (ex is FormatException)
            {
               errorLabel.Text = "Invalid format in the Amount Field. Please Correct";
            }
            else
            {
               errorLabel.Text = ex.Message;
            }
         }
      }

      private void EndOfMonthButton_Click(object sender, EventArgs e)
      {
         foreach (var item in accounts)
         {
            item.closeMonth();
         }
         messageLabel.Text = "End of Month processing has completed.";
      }

      private void ReportButton_Click(object sender, EventArgs e)
      {
         string report = string.Empty;
         foreach (var item in accounts)
         {
            report += item + "\n";
         }
         MessageBox.Show(report);
      }
   }
}
