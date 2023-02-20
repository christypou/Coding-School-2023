namespace FuelStation.WinForms
{
	partial class FuelStation
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnToManager = new System.Windows.Forms.Button();
			this.BtnToStaff = new System.Windows.Forms.Button();
			this.BtnToCashier = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnToManager
			// 
			this.btnToManager.Location = new System.Drawing.Point(119, 208);
			this.btnToManager.Name = "btnToManager";
			this.btnToManager.Size = new System.Drawing.Size(112, 34);
			this.btnToManager.TabIndex = 0;
			this.btnToManager.Text = "Manager";
			this.btnToManager.UseVisualStyleBackColor = true;
			this.btnToManager.Click += new System.EventHandler(this.btnToManager_Click_1);
			// 
			// BtnToStaff
			// 
			this.BtnToStaff.Location = new System.Drawing.Point(344, 208);
			this.BtnToStaff.Name = "BtnToStaff";
			this.BtnToStaff.Size = new System.Drawing.Size(112, 34);
			this.BtnToStaff.TabIndex = 1;
			this.BtnToStaff.Text = "Staff";
			this.BtnToStaff.UseVisualStyleBackColor = true;
			this.BtnToStaff.Click += new System.EventHandler(this.BtnToStaff_Click);
			// 
			// BtnToCashier
			// 
			this.BtnToCashier.Location = new System.Drawing.Point(555, 208);
			this.BtnToCashier.Name = "BtnToCashier";
			this.BtnToCashier.Size = new System.Drawing.Size(112, 34);
			this.BtnToCashier.TabIndex = 2;
			this.BtnToCashier.Text = "Cashier";
			this.BtnToCashier.UseVisualStyleBackColor = true;
			// 
			// FuelStation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnToCashier);
			this.Controls.Add(this.BtnToStaff);
			this.Controls.Add(this.btnToManager);
			this.Name = "FuelStation";
			this.Text = "Fuel Station";
			this.Load += new System.EventHandler(this.FuelStation_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Button btnToManager;
		private Button BtnToStaff;
		private Button BtnToCashier;
	}
}