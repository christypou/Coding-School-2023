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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnToManagers = new System.Windows.Forms.Button();
            this.btnToStaff = new System.Windows.Forms.Button();
            this.btnToCashier = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(317, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 45);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Sign Up";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnToManagers
            // 
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
            this.btnToCashier.Location = new System.Drawing.Point(530, 278);
            this.btnToCashier.Name = "btnToCashier";
            this.btnToCashier.Size = new System.Drawing.Size(112, 34);
            this.btnToCashier.TabIndex = 4;
            this.btnToCashier.Text = "Cashier";
            this.btnToCashier.UseVisualStyleBackColor = true;
            this.btnToCashier.Click += new System.EventHandler(this.btnToCashier_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(124, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(547, 71);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Welcome to Fuel Station";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnToCashier);
            this.Controls.Add(this.btnToStaff);
            this.Controls.Add(this.btnToManagers);
            this.Controls.Add(this.textBox2);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private Button btnToManagers;
        private Button btnToStaff;
        private Button btnToCashier;
        private TextBox textBox1;
    }
}