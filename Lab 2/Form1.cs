using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
   public partial class bankForm : Form
   {
      public bankForm()
      {
         InitializeComponent();
      }

      class Account
      {
         public int id;
         public decimal balance;
      }

      List<Account> accounts = new List<Account>(19);

      private void CreateAccountButton_Click_1(object sender, EventArgs e)
      {
         Account acc = new Account();
         acc.id = Convert.ToInt32(accounts.Count + 1);
         accountIDTextBox.Text = Convert.ToString(accounts.Count + 1);
         acc.balance = Convert.ToDecimal(amountTextBox.Text);
         accounts.Add(acc);
         messageLabel.Text = "Account " + "#" + acc.id + " opened with the balance of $" + acc.balance;
      }

      private void ExecuteButton_Click(object sender, EventArgs e)
      {
         for (int i = 0; i < accounts.Count; i++)
         {
            if (accounts[i].id == Convert.ToInt32(accountIDTextBox.Text))
            {
               if (depositRadioButton.Checked == true)
               {
                  decimal depositAmount = Convert.ToDecimal(amountTextBox.Text);

                  messageLabel.Text = "deposit";
                  var deposit =
                     from account in accounts
                     where account.id == Convert.ToInt32(accountIDTextBox.Text)
                     select (decimal)account.balance;

                  foreach (var item in accounts)
                  {
                     if (item.id == Convert.ToInt32(accountIDTextBox.Text))
                     {
                        item.balance = item.balance + Convert.ToDecimal(amountTextBox.Text);
                        messageLabel.Text = ("$" + Convert.ToString(amountTextBox.Text) + " deposited into Account #" + Convert.ToString(item.id));
                     }
                  }
               }
               if (withdrawRadioButto.Checked == true)
               {
                  foreach (var item in accounts)
                  {
                     if (item.id == Convert.ToInt32(accountIDTextBox.Text))
                     {
                        item.balance = item.balance - Convert.ToDecimal(amountTextBox.Text);
                        messageLabel.Text = ("$" + Convert.ToString(amountTextBox.Text) + " withdrawn from Account #" + Convert.ToString(item.id));
                     }
                  }

               }
               if (balanceRadioButton.Checked == true)
               {
                 
                  foreach (var item in accounts)
                  {
                     if (item.id == Convert.ToInt32(accountIDTextBox.Text))
                     {
                        messageLabel.Text = ("Account #" + Convert.ToString(item.id) + " has a balance of $" + Convert.ToString(item.balance));
                     }
                  }
               }
            }
         }
      }
   }
}
