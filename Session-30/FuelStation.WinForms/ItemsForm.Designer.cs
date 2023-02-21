namespace FuelStation.WinForms
{
	partial class ItemsForm
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
			this.grvItems = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			this.SuspendLayout();
			// 
			// grvItems
			// 
			this.grvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvItems.Location = new System.Drawing.Point(45, 44);
			this.grvItems.Name = "grvItems";
			this.grvItems.RowHeadersWidth = 62;
			this.grvItems.RowTemplate.Height = 33;
			this.grvItems.Size = new System.Drawing.Size(700, 366);
			this.grvItems.TabIndex = 0;
			// 
			// ItemsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grvItems);
			this.Name = "ItemsForm";
			this.Text = "Items";
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView grvItems;
	}
}