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
			this.customerbs = new System.Windows.Forms.BindingSource(this.components);
			this.httpContextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.requestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.responseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.routeDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.controllerContextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metadataProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelBinderFactoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.objectValidatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.problemDetailsFactoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerbs)).BeginInit();
			this.SuspendLayout();
			// 
			// grvCustomers
			// 
			this.grvCustomers.AutoGenerateColumns = false;
			this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerSurname,
            this.CustomerCardNumber,
            this.httpContextDataGridViewTextBoxColumn,
            this.requestDataGridViewTextBoxColumn,
            this.responseDataGridViewTextBoxColumn,
            this.routeDataDataGridViewTextBoxColumn,
            this.modelStateDataGridViewTextBoxColumn,
            this.controllerContextDataGridViewTextBoxColumn,
            this.metadataProviderDataGridViewTextBoxColumn,
            this.modelBinderFactoryDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.objectValidatorDataGridViewTextBoxColumn,
            this.problemDetailsFactoryDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
			this.grvCustomers.DataSource = this.customerbs;
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
			// customerbs
			// 
			this.customerbs.DataSource = typeof(FuelStation.Web.Blazor.Server.Controllers.CustomerController);
			// 
			// httpContextDataGridViewTextBoxColumn
			// 
			this.httpContextDataGridViewTextBoxColumn.DataPropertyName = "HttpContext";
			this.httpContextDataGridViewTextBoxColumn.HeaderText = "HttpContext";
			this.httpContextDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.httpContextDataGridViewTextBoxColumn.Name = "httpContextDataGridViewTextBoxColumn";
			this.httpContextDataGridViewTextBoxColumn.ReadOnly = true;
			this.httpContextDataGridViewTextBoxColumn.Width = 150;
			// 
			// requestDataGridViewTextBoxColumn
			// 
			this.requestDataGridViewTextBoxColumn.DataPropertyName = "Request";
			this.requestDataGridViewTextBoxColumn.HeaderText = "Request";
			this.requestDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.requestDataGridViewTextBoxColumn.Name = "requestDataGridViewTextBoxColumn";
			this.requestDataGridViewTextBoxColumn.ReadOnly = true;
			this.requestDataGridViewTextBoxColumn.Width = 150;
			// 
			// responseDataGridViewTextBoxColumn
			// 
			this.responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
			this.responseDataGridViewTextBoxColumn.HeaderText = "Response";
			this.responseDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
			this.responseDataGridViewTextBoxColumn.ReadOnly = true;
			this.responseDataGridViewTextBoxColumn.Width = 150;
			// 
			// routeDataDataGridViewTextBoxColumn
			// 
			this.routeDataDataGridViewTextBoxColumn.DataPropertyName = "RouteData";
			this.routeDataDataGridViewTextBoxColumn.HeaderText = "RouteData";
			this.routeDataDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.routeDataDataGridViewTextBoxColumn.Name = "routeDataDataGridViewTextBoxColumn";
			this.routeDataDataGridViewTextBoxColumn.ReadOnly = true;
			this.routeDataDataGridViewTextBoxColumn.Width = 150;
			// 
			// modelStateDataGridViewTextBoxColumn
			// 
			this.modelStateDataGridViewTextBoxColumn.DataPropertyName = "ModelState";
			this.modelStateDataGridViewTextBoxColumn.HeaderText = "ModelState";
			this.modelStateDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.modelStateDataGridViewTextBoxColumn.Name = "modelStateDataGridViewTextBoxColumn";
			this.modelStateDataGridViewTextBoxColumn.ReadOnly = true;
			this.modelStateDataGridViewTextBoxColumn.Width = 150;
			// 
			// controllerContextDataGridViewTextBoxColumn
			// 
			this.controllerContextDataGridViewTextBoxColumn.DataPropertyName = "ControllerContext";
			this.controllerContextDataGridViewTextBoxColumn.HeaderText = "ControllerContext";
			this.controllerContextDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.controllerContextDataGridViewTextBoxColumn.Name = "controllerContextDataGridViewTextBoxColumn";
			this.controllerContextDataGridViewTextBoxColumn.Width = 150;
			// 
			// metadataProviderDataGridViewTextBoxColumn
			// 
			this.metadataProviderDataGridViewTextBoxColumn.DataPropertyName = "MetadataProvider";
			this.metadataProviderDataGridViewTextBoxColumn.HeaderText = "MetadataProvider";
			this.metadataProviderDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.metadataProviderDataGridViewTextBoxColumn.Name = "metadataProviderDataGridViewTextBoxColumn";
			this.metadataProviderDataGridViewTextBoxColumn.Width = 150;
			// 
			// modelBinderFactoryDataGridViewTextBoxColumn
			// 
			this.modelBinderFactoryDataGridViewTextBoxColumn.DataPropertyName = "ModelBinderFactory";
			this.modelBinderFactoryDataGridViewTextBoxColumn.HeaderText = "ModelBinderFactory";
			this.modelBinderFactoryDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.modelBinderFactoryDataGridViewTextBoxColumn.Name = "modelBinderFactoryDataGridViewTextBoxColumn";
			this.modelBinderFactoryDataGridViewTextBoxColumn.Width = 150;
			// 
			// urlDataGridViewTextBoxColumn
			// 
			this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
			this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
			this.urlDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
			this.urlDataGridViewTextBoxColumn.Width = 150;
			// 
			// objectValidatorDataGridViewTextBoxColumn
			// 
			this.objectValidatorDataGridViewTextBoxColumn.DataPropertyName = "ObjectValidator";
			this.objectValidatorDataGridViewTextBoxColumn.HeaderText = "ObjectValidator";
			this.objectValidatorDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.objectValidatorDataGridViewTextBoxColumn.Name = "objectValidatorDataGridViewTextBoxColumn";
			this.objectValidatorDataGridViewTextBoxColumn.Width = 150;
			// 
			// problemDetailsFactoryDataGridViewTextBoxColumn
			// 
			this.problemDetailsFactoryDataGridViewTextBoxColumn.DataPropertyName = "ProblemDetailsFactory";
			this.problemDetailsFactoryDataGridViewTextBoxColumn.HeaderText = "ProblemDetailsFactory";
			this.problemDetailsFactoryDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.problemDetailsFactoryDataGridViewTextBoxColumn.Name = "problemDetailsFactoryDataGridViewTextBoxColumn";
			this.problemDetailsFactoryDataGridViewTextBoxColumn.Width = 150;
			// 
			// userDataGridViewTextBoxColumn
			// 
			this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
			this.userDataGridViewTextBoxColumn.HeaderText = "User";
			this.userDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
			this.userDataGridViewTextBoxColumn.ReadOnly = true;
			this.userDataGridViewTextBoxColumn.Width = 150;
			// 
			// CustomersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grvCustomers);
			this.Name = "CustomersForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.CustomersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerbs)).EndInit();
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
		private BindingSource customerbs;
	}
}