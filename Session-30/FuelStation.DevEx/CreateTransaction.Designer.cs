namespace FuelStation.DevEx
{
	partial class CreateTransaction
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
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.btnToIndex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(261, 137);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PlaceholderText = "Add Customer\'s Card Number";
            this.txtCardNumber.Size = new System.Drawing.Size(264, 31);
            this.txtCardNumber.TabIndex = 0;
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(299, 195);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(165, 34);
            this.btnCreateTransaction.TabIndex = 1;
            this.btnCreateTransaction.Text = "Create Transaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // btnToIndex
            // 
            this.btnToIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToIndex.Location = new System.Drawing.Point(23, 393);
            this.btnToIndex.Name = "btnToIndex";
            this.btnToIndex.Size = new System.Drawing.Size(141, 34);
            this.btnToIndex.TabIndex = 2;
            this.btnToIndex.Text = "Back To Home";
            this.btnToIndex.UseVisualStyleBackColor = true;
            this.btnToIndex.Click += new System.EventHandler(this.btnToIndex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Customer\'s Card Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToIndex);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.txtCardNumber);
            this.Name = "CreateTransaction";
            this.Text = "CreateTransaction";
            this.Load += new System.EventHandler(this.CreateTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TextBox txtCardNumber;
		private Button btnCreateTransaction;
        private Button btnToIndex;
        private Label label1;
    }
}