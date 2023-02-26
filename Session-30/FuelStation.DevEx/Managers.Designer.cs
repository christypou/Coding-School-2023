namespace FuelStation.DevEx
{
    partial class Managers
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
			this.btnToItems = new System.Windows.Forms.Button();
			this.btnToCreateTransaction = new System.Windows.Forms.Button();
			this.btnToViewTransactions = new System.Windows.Forms.Button();
			this.btnBackToIndex = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnToCustomers
			// 
			this.btnToCustomers.Location = new System.Drawing.Point(121, 247);
			this.btnToCustomers.Name = "btnToCustomers";
			this.btnToCustomers.Size = new System.Drawing.Size(112, 34);
			this.btnToCustomers.TabIndex = 1;
			this.btnToCustomers.Text = "Customers";
			this.btnToCustomers.UseVisualStyleBackColor = true;
			this.btnToCustomers.Click += new System.EventHandler(this.btnToCustomers_Click);
			// 
			// btnToItems
			// 
			this.btnToItems.Location = new System.Drawing.Point(352, 247);
			this.btnToItems.Name = "btnToItems";
			this.btnToItems.Size = new System.Drawing.Size(112, 34);
			this.btnToItems.TabIndex = 2;
			this.btnToItems.Text = "Items";
			this.btnToItems.UseVisualStyleBackColor = true;
			this.btnToItems.Click += new System.EventHandler(this.btnToItems_Click);
			// 
			// btnToCreateTransaction
			// 
			this.btnToCreateTransaction.Location = new System.Drawing.Point(580, 247);
			this.btnToCreateTransaction.Name = "btnToCreateTransaction";
			this.btnToCreateTransaction.Size = new System.Drawing.Size(112, 34);
			this.btnToCreateTransaction.TabIndex = 3;
			this.btnToCreateTransaction.Text = "Transaction";
			this.btnToCreateTransaction.UseVisualStyleBackColor = true;
			this.btnToCreateTransaction.Click += new System.EventHandler(this.btnToCreateTransaction_Click);
			// 
			// btnToViewTransactions
			// 
			this.btnToViewTransactions.Location = new System.Drawing.Point(352, 332);
			this.btnToViewTransactions.Name = "btnToViewTransactions";
			this.btnToViewTransactions.Size = new System.Drawing.Size(112, 34);
			this.btnToViewTransactions.TabIndex = 4;
			this.btnToViewTransactions.Text = "History";
			this.btnToViewTransactions.UseVisualStyleBackColor = true;
			this.btnToViewTransactions.Click += new System.EventHandler(this.btnToViewTransactions_Click);
			// 
			// btnBackToIndex
			// 
			this.btnBackToIndex.Location = new System.Drawing.Point(28, 391);
			this.btnBackToIndex.Name = "btnBackToIndex";
			this.btnBackToIndex.Size = new System.Drawing.Size(112, 34);
			this.btnBackToIndex.TabIndex = 5;
			this.btnBackToIndex.Text = "Back";
			this.btnBackToIndex.UseVisualStyleBackColor = true;
			this.btnBackToIndex.Click += new System.EventHandler(this.btnBackToIndex_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(301, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 38);
			this.label1.TabIndex = 6;
			this.label1.Text = "Hello Manager";
			// 
			// Managers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBackToIndex);
			this.Controls.Add(this.btnToViewTransactions);
			this.Controls.Add(this.btnToCreateTransaction);
			this.Controls.Add(this.btnToItems);
			this.Controls.Add(this.btnToCustomers);
			this.Name = "Managers";
			this.Text = "Managers";
			this.Load += new System.EventHandler(this.Managers_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Button btnToCustomers;
        private Button btnToItems;
        private Button btnToCreateTransaction;
        private Button btnToViewTransactions;
        private Button btnBackToIndex;
		private Label label1;
	}
}