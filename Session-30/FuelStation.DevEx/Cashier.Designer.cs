namespace FuelStation.DevEx
{
    partial class Cashier
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnToCustomers = new System.Windows.Forms.Button();
            this.btnToCreateTransaction = new System.Windows.Forms.Button();
            this.btnToViewTransactions = new System.Windows.Forms.Button();
            this.btnBackToIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(275, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(265, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome Cashier";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnToCustomers
            // 
            this.btnToCustomers.Location = new System.Drawing.Point(217, 259);
            this.btnToCustomers.Name = "btnToCustomers";
            this.btnToCustomers.Size = new System.Drawing.Size(112, 34);
            this.btnToCustomers.TabIndex = 1;
            this.btnToCustomers.Text = "Customers";
            this.btnToCustomers.UseVisualStyleBackColor = true;
            this.btnToCustomers.Click += new System.EventHandler(this.btnToCustomers_Click);
            // 
            // btnToCreateTransaction
            // 
            this.btnToCreateTransaction.Location = new System.Drawing.Point(443, 259);
            this.btnToCreateTransaction.Name = "btnToCreateTransaction";
            this.btnToCreateTransaction.Size = new System.Drawing.Size(112, 34);
            this.btnToCreateTransaction.TabIndex = 2;
            this.btnToCreateTransaction.Text = "Transaction";
            this.btnToCreateTransaction.UseVisualStyleBackColor = true;
            this.btnToCreateTransaction.Click += new System.EventHandler(this.btnToCreateTransaction_Click);
            // 
            // btnToViewTransactions
            // 
            this.btnToViewTransactions.Location = new System.Drawing.Point(334, 324);
            this.btnToViewTransactions.Name = "btnToViewTransactions";
            this.btnToViewTransactions.Size = new System.Drawing.Size(112, 34);
            this.btnToViewTransactions.TabIndex = 3;
            this.btnToViewTransactions.Text = "History";
            this.btnToViewTransactions.UseVisualStyleBackColor = true;
            this.btnToViewTransactions.Click += new System.EventHandler(this.btnToViewTransactions_Click);
            // 
            // btnBackToIndex
            // 
            this.btnBackToIndex.Location = new System.Drawing.Point(34, 394);
            this.btnBackToIndex.Name = "btnBackToIndex";
            this.btnBackToIndex.Size = new System.Drawing.Size(112, 34);
            this.btnBackToIndex.TabIndex = 4;
            this.btnBackToIndex.Text = "Back";
            this.btnBackToIndex.UseVisualStyleBackColor = true;
            this.btnBackToIndex.Click += new System.EventHandler(this.btnBackToIndex_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToIndex);
            this.Controls.Add(this.btnToViewTransactions);
            this.Controls.Add(this.btnToCreateTransaction);
            this.Controls.Add(this.btnToCustomers);
            this.Controls.Add(this.textBox1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnToCustomers;
        private Button btnToCreateTransaction;
        private Button btnToViewTransactions;
        private Button btnBackToIndex;
    }
}