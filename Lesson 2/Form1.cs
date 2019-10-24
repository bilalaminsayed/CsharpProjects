//
using System;
using System.Windows.Forms;

namespace Lesson_2
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Button1_Click(object sender, EventArgs e)
      {
         //get user input
         decimal principal = decimal.Parse(textBox1.Text);
         double rate = double.Parse(textBox2.Text);
         int year = (int)numericUpDown1.Value;

         //set output header
         string output = "Year\tAmount on Deposit\r\n";

         //calculate amount after each year and append to output
         for (int yearCounter = 1; yearCounter <= year; ++yearCounter)
         {
            decimal amount = principal * 
               ((decimal) Math.Pow((1 + rate / 100), yearCounter));
            output += $"{yearCounter}\t{amount:C}\r\n";
         }

         textBox3.Text = output; //display result

      }
   }
}
