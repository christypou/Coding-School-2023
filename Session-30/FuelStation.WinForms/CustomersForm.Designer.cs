namespace FuelStation.WinForms
{
	partial class CustomersForm
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
			this.components = new System.ComponentModel.Container();
			this.grvCustomers = new System.Windows.Forms.DataGridView();
			this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerBs = new System.Windows.Forms.BindingSource(this.components);
			this.btnSaveCustomer = new System.Windows.Forms.Button();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomerBs)).BeginInit();
			this.SuspendLayout();
			// 
			// grvCustomers
			// 
			this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerSurname,
            this.CustomerCardNumber});
			this.grvCustomers.Location = new System.Drawing.Point(39, 34);
			this.grvCustomers.Name = "grvCustomers";
			this.grvCustomers.RowHeadersWidth = 62;
			this.grvCustomers.RowTemplate.Height = 33;
			this.grvCustomers.Size = new System.Drawing.Size(717, 380);
			this.grvCustomers.TabIndex = 0;
			// 
			// CustomerName
			// 
			this.CustomerName.HeaderText = "Name";
			this.CustomerName.MinimumWidth = 8;
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Width = 150;
			// 
			// CustomerSurname
			// 
			this.CustomerSurname.HeaderText = "Surname";
			this.CustomerSurname.MinimumWidth = 8;
			this.CustomerSurname.Name = "CustomerSurname";
			this.CustomerSurname.Width = 150;
			// 
			// CustomerCardNumber
			// 
			this.CustomerCardNumber.HeaderText = "Card Number";
			this.CustomerCardNumber.MinimumWidth = 8;
			this.CustomerCardNumber.Name = "CustomerCardNumber";
			this.CustomerCardNumber.Width = 150;
			// 
			// btnSaveCustomer
			// 
			this.btnSaveCustomer.Location = new System.Drawing.Point(785, 87);
			this.btnSaveCustomer.Name = "btnSaveCustomer";
			this.btnSaveCustomer.Size = new System.Drawing.Size(112, 34);
			this.btnSaveCustomer.TabIndex = 1;
			this.btnSaveCustomer.Text = "Save";
			this.btnSaveCustomer.UseVisualStyleBackColor = true;
			this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.Location = new System.Drawing.Point(785, 258);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(112, 34);
			this.btnDeleteCustomer.TabIndex = 2;
			this.btnDeleteCustomer.Text = "Delete";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			// 
			// CustomersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 450);
			this.Controls.Add(this.btnDeleteCustomer);
			this.Controls.Add(this.btnSaveCustomer);
			this.Controls.Add(this.grvCustomers);
			this.Name = "CustomersForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.CustomersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomerBs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView grvCustomers;
		private DataGridViewTextBoxColumn CustomerName;
		private DataGridViewTextBoxColumn CustomerSurname;
		private DataGridViewTextBoxColumn CustomerCardNumber;
		private DataGridViewTextBoxColumn httpContextDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn requestDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn routeDataDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn modelStateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn controllerContextDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn metadataProviderDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn modelBinderFactoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn objectValidatorDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn problemDetailsFactoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
		private BindingSource CustomerBs;
		private Button btnSaveCustomer;
		private Button btnDeleteCustomer;
	}
}