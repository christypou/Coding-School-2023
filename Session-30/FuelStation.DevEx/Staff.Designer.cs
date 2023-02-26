namespace FuelStation.DevEx
{
    partial class Staff
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
            this.btnToItems = new System.Windows.Forms.Button();
            this.btnBackToIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(264, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Hello Staff Member";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnToItems
            // 
            this.btnToItems.Location = new System.Drawing.Point(336, 251);
            this.btnToItems.Name = "btnToItems";
            this.btnToItems.Size = new System.Drawing.Size(112, 34);
            this.btnToItems.TabIndex = 1;
            this.btnToItems.Text = "Items";
            this.btnToItems.UseVisualStyleBackColor = true;
            this.btnToItems.Click += new System.EventHandler(this.btnToItems_Click);
            // 
            // btnBackToIndex
            // 
            this.btnBackToIndex.Location = new System.Drawing.Point(33, 389);
            this.btnBackToIndex.Name = "btnBackToIndex";
            this.btnBackToIndex.Size = new System.Drawing.Size(112, 34);
            this.btnBackToIndex.TabIndex = 2;
            this.btnBackToIndex.Text = "Back";
            this.btnBackToIndex.UseVisualStyleBackColor = true;
            this.btnBackToIndex.Click += new System.EventHandler(this.btnBackToIndex_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToIndex);
            this.Controls.Add(this.btnToItems);
            this.Controls.Add(this.textBox1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnToItems;
        private Button btnBackToIndex;
    }
}