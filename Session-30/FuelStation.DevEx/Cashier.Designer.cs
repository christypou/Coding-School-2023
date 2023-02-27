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
            this.btnToCustomers = new System.Windows.Forms.Button();
            this.btnToCreateTransaction = new System.Windows.Forms.Button();
            this.btnToViewTransactions = new System.Windows.Forms.Button();
            this.btnBackToIndex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnBackToIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackToIndex.Location = new System.Drawing.Point(34, 394);
            this.btnBackToIndex.Name = "btnBackToIndex";
            this.btnBackToIndex.Size = new System.Drawing.Size(112, 34);
            this.btnBackToIndex.TabIndex = 4;
            this.btnBackToIndex.Text = "Back";
            this.btnBackToIndex.UseVisualStyleBackColor = true;
            this.btnBackToIndex.Click += new System.EventHandler(this.btnBackToIndex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Cashier";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToIndex);
            this.Controls.Add(this.btnToViewTransactions);
            this.Controls.Add(this.btnToCreateTransaction);
            this.Controls.Add(this.btnToCustomers);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnToCustomers;
        private Button btnToCreateTransaction;
        private Button btnToViewTransactions;
        private Button btnBackToIndex;
		private Label label1;
	}
}