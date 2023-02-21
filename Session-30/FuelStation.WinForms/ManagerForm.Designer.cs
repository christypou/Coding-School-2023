namespace FuelStation.WinForms
{
	partial class ManagerForm
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
			this.SuspendLayout();
			// 
			// btnToCustomers
			// 
			this.btnToCustomers.Location = new System.Drawing.Point(126, 161);
			this.btnToCustomers.Name = "btnToCustomers";
			this.btnToCustomers.Size = new System.Drawing.Size(112, 34);
			this.btnToCustomers.TabIndex = 0;
			this.btnToCustomers.Text = "Customers";
			this.btnToCustomers.UseVisualStyleBackColor = true;
			this.btnToCustomers.Click += new System.EventHandler(this.btnToCustomers_Click);
			// 
			// btnToItems
			// 
			this.btnToItems.Location = new System.Drawing.Point(332, 161);
			this.btnToItems.Name = "btnToItems";
			this.btnToItems.Size = new System.Drawing.Size(112, 34);
			this.btnToItems.TabIndex = 1;
			this.btnToItems.Text = "Items";
			this.btnToItems.UseVisualStyleBackColor = true;
			this.btnToItems.Click += new System.EventHandler(this.btnToItems_Click);
			// 
			// ManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnToItems);
			this.Controls.Add(this.btnToCustomers);
			this.Name = "ManagerForm";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnToCustomers;
		private Button btnToItems;
	}
}