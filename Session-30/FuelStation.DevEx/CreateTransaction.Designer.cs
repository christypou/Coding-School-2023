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
			// CreateTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCreateTransaction);
			this.Controls.Add(this.txtCardNumber);
			this.Name = "CreateTransaction";
			this.Text = "CreateTransaction";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtCardNumber;
		private Button btnCreateTransaction;
	}
}