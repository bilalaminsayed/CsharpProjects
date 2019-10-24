namespace Lab_2
{
   partial class bankForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.accountIDTextBox = new System.Windows.Forms.TextBox();
         this.amountTextBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.depositRadioButton = new System.Windows.Forms.RadioButton();
         this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
         this.balanceRadioButton = new System.Windows.Forms.RadioButton();
         this.ExecuteButton = new System.Windows.Forms.Button();
         this.CreateAccountButton = new System.Windows.Forms.Button();
         this.messageLabel = new System.Windows.Forms.Label();
         this.checkingsRadioButton = new System.Windows.Forms.RadioButton();
         this.savingsRadioButton = new System.Windows.Forms.RadioButton();
         this.collegeStudentCheckBox = new System.Windows.Forms.CheckBox();
         this.seniorCitizenCheckBox = new System.Windows.Forms.CheckBox();
         this.EndOfMonthButton = new System.Windows.Forms.Button();
         this.ReportButton = new System.Windows.Forms.Button();
         this.errorLabel = new System.Windows.Forms.Label();
         this.loadLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(95, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(86, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "ITSE 2453 Bank";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(102, 22);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Dallas, Texas";
         // 
         // accountIDTextBox
         // 
         this.accountIDTextBox.Location = new System.Drawing.Point(12, 59);
         this.accountIDTextBox.Name = "accountIDTextBox";
         this.accountIDTextBox.Size = new System.Drawing.Size(100, 20);
         this.accountIDTextBox.TabIndex = 2;
         // 
         // amountTextBox
         // 
         this.amountTextBox.Location = new System.Drawing.Point(162, 59);
         this.amountTextBox.Name = "amountTextBox";
         this.amountTextBox.Size = new System.Drawing.Size(100, 20);
         this.amountTextBox.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(29, 82);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(61, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Account ID";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(193, 82);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(43, 13);
         this.label4.TabIndex = 5;
         this.label4.Text = "Amount";
         // 
         // depositRadioButton
         // 
         this.depositRadioButton.AutoSize = true;
         this.depositRadioButton.Location = new System.Drawing.Point(162, 109);
         this.depositRadioButton.Name = "depositRadioButton";
         this.depositRadioButton.Size = new System.Drawing.Size(61, 17);
         this.depositRadioButton.TabIndex = 6;
         this.depositRadioButton.TabStop = true;
         this.depositRadioButton.Text = "Deposit";
         this.depositRadioButton.UseVisualStyleBackColor = true;
         // 
         // withdrawRadioButton
         // 
         this.withdrawRadioButton.AutoSize = true;
         this.withdrawRadioButton.Location = new System.Drawing.Point(162, 132);
         this.withdrawRadioButton.Name = "withdrawRadioButton";
         this.withdrawRadioButton.Size = new System.Drawing.Size(70, 17);
         this.withdrawRadioButton.TabIndex = 7;
         this.withdrawRadioButton.TabStop = true;
         this.withdrawRadioButton.Text = "Withdraw";
         this.withdrawRadioButton.UseVisualStyleBackColor = true;
         // 
         // balanceRadioButton
         // 
         this.balanceRadioButton.AutoSize = true;
         this.balanceRadioButton.Location = new System.Drawing.Point(162, 155);
         this.balanceRadioButton.Name = "balanceRadioButton";
         this.balanceRadioButton.Size = new System.Drawing.Size(64, 17);
         this.balanceRadioButton.TabIndex = 8;
         this.balanceRadioButton.TabStop = true;
         this.balanceRadioButton.Text = "Balance";
         this.balanceRadioButton.UseVisualStyleBackColor = true;
         // 
         // ExecuteButton
         // 
         this.ExecuteButton.Location = new System.Drawing.Point(162, 226);
         this.ExecuteButton.Name = "ExecuteButton";
         this.ExecuteButton.Size = new System.Drawing.Size(100, 23);
         this.ExecuteButton.TabIndex = 9;
         this.ExecuteButton.Text = "Execute";
         this.ExecuteButton.UseVisualStyleBackColor = true;
         this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
         // 
         // CreateAccountButton
         // 
         this.CreateAccountButton.Location = new System.Drawing.Point(12, 226);
         this.CreateAccountButton.Name = "CreateAccountButton";
         this.CreateAccountButton.Size = new System.Drawing.Size(100, 23);
         this.CreateAccountButton.TabIndex = 10;
         this.CreateAccountButton.Text = "Create Account";
         this.CreateAccountButton.UseVisualStyleBackColor = true;
         this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click_1);
         // 
         // messageLabel
         // 
         this.messageLabel.AutoSize = true;
         this.messageLabel.ForeColor = System.Drawing.Color.Green;
         this.messageLabel.Location = new System.Drawing.Point(12, 316);
         this.messageLabel.Name = "messageLabel";
         this.messageLabel.Size = new System.Drawing.Size(0, 13);
         this.messageLabel.TabIndex = 11;
         // 
         // checkingsRadioButton
         // 
         this.checkingsRadioButton.AutoSize = true;
         this.checkingsRadioButton.Location = new System.Drawing.Point(15, 109);
         this.checkingsRadioButton.Name = "checkingsRadioButton";
         this.checkingsRadioButton.Size = new System.Drawing.Size(75, 17);
         this.checkingsRadioButton.TabIndex = 12;
         this.checkingsRadioButton.TabStop = true;
         this.checkingsRadioButton.Text = "Checkings";
         this.checkingsRadioButton.UseVisualStyleBackColor = true;
         // 
         // savingsRadioButton
         // 
         this.savingsRadioButton.AutoSize = true;
         this.savingsRadioButton.Location = new System.Drawing.Point(15, 132);
         this.savingsRadioButton.Name = "savingsRadioButton";
         this.savingsRadioButton.Size = new System.Drawing.Size(63, 17);
         this.savingsRadioButton.TabIndex = 13;
         this.savingsRadioButton.TabStop = true;
         this.savingsRadioButton.Text = "Savings";
         this.savingsRadioButton.UseVisualStyleBackColor = true;
         // 
         // collegeStudentCheckBox
         // 
         this.collegeStudentCheckBox.AutoSize = true;
         this.collegeStudentCheckBox.Location = new System.Drawing.Point(15, 169);
         this.collegeStudentCheckBox.Name = "collegeStudentCheckBox";
         this.collegeStudentCheckBox.Size = new System.Drawing.Size(101, 17);
         this.collegeStudentCheckBox.TabIndex = 14;
         this.collegeStudentCheckBox.Text = "College Student";
         this.collegeStudentCheckBox.UseVisualStyleBackColor = true;
         // 
         // seniorCitizenCheckBox
         // 
         this.seniorCitizenCheckBox.AutoSize = true;
         this.seniorCitizenCheckBox.Location = new System.Drawing.Point(15, 192);
         this.seniorCitizenCheckBox.Name = "seniorCitizenCheckBox";
         this.seniorCitizenCheckBox.Size = new System.Drawing.Size(90, 17);
         this.seniorCitizenCheckBox.TabIndex = 15;
         this.seniorCitizenCheckBox.Text = "Senior Citizen";
         this.seniorCitizenCheckBox.UseVisualStyleBackColor = true;
         // 
         // EndOfMonthButton
         // 
         this.EndOfMonthButton.Location = new System.Drawing.Point(12, 271);
         this.EndOfMonthButton.Name = "EndOfMonthButton";
         this.EndOfMonthButton.Size = new System.Drawing.Size(100, 23);
         this.EndOfMonthButton.TabIndex = 16;
         this.EndOfMonthButton.Text = "End of Month";
         this.EndOfMonthButton.UseVisualStyleBackColor = true;
         this.EndOfMonthButton.Click += new System.EventHandler(this.EndOfMonthButton_Click);
         // 
         // ReportButton
         // 
         this.ReportButton.Location = new System.Drawing.Point(162, 271);
         this.ReportButton.Name = "ReportButton";
         this.ReportButton.Size = new System.Drawing.Size(100, 23);
         this.ReportButton.TabIndex = 17;
         this.ReportButton.Text = "Report";
         this.ReportButton.UseVisualStyleBackColor = true;
         this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
         // 
         // errorLabel
         // 
         this.errorLabel.AutoSize = true;
         this.errorLabel.ForeColor = System.Drawing.Color.Red;
         this.errorLabel.Location = new System.Drawing.Point(18, 316);
         this.errorLabel.Name = "errorLabel";
         this.errorLabel.Size = new System.Drawing.Size(0, 13);
         this.errorLabel.TabIndex = 18;
         // 
         // loadLabel
         // 
         this.loadLabel.AutoSize = true;
         this.loadLabel.ForeColor = System.Drawing.Color.Blue;
         this.loadLabel.Location = new System.Drawing.Point(12, 315);
         this.loadLabel.Name = "loadLabel";
         this.loadLabel.Size = new System.Drawing.Size(0, 13);
         this.loadLabel.TabIndex = 19;
         // 
         // bankForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(311, 352);
         this.Controls.Add(this.loadLabel);
         this.Controls.Add(this.errorLabel);
         this.Controls.Add(this.ReportButton);
         this.Controls.Add(this.EndOfMonthButton);
         this.Controls.Add(this.seniorCitizenCheckBox);
         this.Controls.Add(this.collegeStudentCheckBox);
         this.Controls.Add(this.savingsRadioButton);
         this.Controls.Add(this.checkingsRadioButton);
         this.Controls.Add(this.messageLabel);
         this.Controls.Add(this.CreateAccountButton);
         this.Controls.Add(this.ExecuteButton);
         this.Controls.Add(this.balanceRadioButton);
         this.Controls.Add(this.withdrawRadioButton);
         this.Controls.Add(this.depositRadioButton);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.amountTextBox);
         this.Controls.Add(this.accountIDTextBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "bankForm";
         this.Text = "`";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox accountIDTextBox;
      private System.Windows.Forms.TextBox amountTextBox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.RadioButton depositRadioButton;
      private System.Windows.Forms.RadioButton withdrawRadioButton;
      private System.Windows.Forms.RadioButton balanceRadioButton;
      private System.Windows.Forms.Button ExecuteButton;
      private System.Windows.Forms.Button CreateAccountButton;
      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.RadioButton checkingsRadioButton;
      private System.Windows.Forms.RadioButton savingsRadioButton;
      private System.Windows.Forms.CheckBox collegeStudentCheckBox;
      private System.Windows.Forms.CheckBox seniorCitizenCheckBox;
      private System.Windows.Forms.Button EndOfMonthButton;
      private System.Windows.Forms.Button ReportButton;
      private System.Windows.Forms.Label errorLabel;
      private System.Windows.Forms.Label loadLabel;
   }
}

