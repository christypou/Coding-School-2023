namespace FuelStation.DevEx
{
    partial class Index
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
			this.btnToManagers = new System.Windows.Forms.Button();
			this.btnToStaff = new System.Windows.Forms.Button();
			this.btnToCashier = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnToManagers
			// 
			this.btnToManagers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToManagers.Location = new System.Drawing.Point(147, 278);
			this.btnToManagers.Name = "btnToManagers";
			this.btnToManagers.Size = new System.Drawing.Size(112, 34);
			this.btnToManagers.TabIndex = 2;
			this.btnToManagers.Text = "Manager";
			this.btnToManagers.UseVisualStyleBackColor = true;
			this.btnToManagers.Click += new System.EventHandler(this.btnToManagers_Click);
			// 
			// btnToStaff
			// 
			this.btnToStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToStaff.Location = new System.Drawing.Point(337, 278);
			this.btnToStaff.Name = "btnToStaff";
			this.btnToStaff.Size = new System.Drawing.Size(112, 34);
			this.btnToStaff.TabIndex = 3;
			this.btnToStaff.Text = "Staff";
			this.btnToStaff.UseVisualStyleBackColor = true;
			this.btnToStaff.Click += new System.EventHandler(this.btnToStaff_Click);
			// 
			// btnToCashier
			// 
			this.btnToCashier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToCashier.Location = new System.Drawing.Point(530, 278);
			this.btnToCashier.Name = "btnToCashier";
			this.btnToCashier.Size = new System.Drawing.Size(112, 34);
			this.btnToCashier.TabIndex = 4;
			this.btnToCashier.Text = "Cashier";
			this.btnToCashier.UseVisualStyleBackColor = true;
			this.btnToCashier.Click += new System.EventHandler(this.btnToCashier_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(133, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(541, 65);
			this.label1.TabIndex = 6;
			this.label1.Text = "Welcome to Fuel Station";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(327, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 45);
			this.label2.TabIndex = 7;
			this.label2.Text = "Sign Up";
			// 
			// Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnToCashier);
			this.Controls.Add(this.btnToStaff);
			this.Controls.Add(this.btnToManagers);
			this.Name = "Index";
			this.Text = "Index";
			this.Load += new System.EventHandler(this.Index_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Button btnToManagers;
        private Button btnToStaff;
        private Button btnToCashier;
		private Label label1;
		private Label label2;
	}
}