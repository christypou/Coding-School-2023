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
			this.btnToItems = new System.Windows.Forms.Button();
			this.btnBackToIndex = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(262, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 41);
			this.label1.TabIndex = 3;
			this.label1.Text = "Hello Staff Member";
			// 
			// Staff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBackToIndex);
			this.Controls.Add(this.btnToItems);
			this.Name = "Staff";
			this.Text = "Staff";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Button btnToItems;
        private Button btnBackToIndex;
		private Label label1;
	}
}