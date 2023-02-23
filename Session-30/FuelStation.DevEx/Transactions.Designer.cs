namespace FuelStation.DevEx
{
	partial class Transactions
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
			this.grdTransactions = new DevExpress.XtraGrid.GridControl();
			this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
			this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
			this.SuspendLayout();
			// 
			// grdTransactions
			// 
			this.grdTransactions.Location = new System.Drawing.Point(12, 12);
			this.grdTransactions.MainView = this.grvTransactions;
			this.grdTransactions.Name = "grdTransactions";
			this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCustomers,
            this.repEmployees});
			this.grdTransactions.Size = new System.Drawing.Size(856, 230);
			this.grdTransactions.TabIndex = 0;
			this.grdTransactions.UseEmbeddedNavigator = true;
			this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
			// 
			// grvTransactions
			// 
			this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colEmployeeName,
            this.colCustomerName,
            this.colPaymentMethod,
            this.colTotalValue});
			this.grvTransactions.GridControl = this.grdTransactions;
			this.grvTransactions.Name = "grvTransactions";
			this.grvTransactions.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grvTransactions_RowDeleting);
			this.grvTransactions.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvTransactions_ValidateRow);
			// 
			// colDate
			// 
			this.colDate.Caption = "Date";
			this.colDate.FieldName = "Date";
			this.colDate.MinWidth = 30;
			this.colDate.Name = "colDate";
			this.colDate.Visible = true;
			this.colDate.VisibleIndex = 0;
			this.colDate.Width = 112;
			// 
			// colEmployeeName
			// 
			this.colEmployeeName.Caption = "Employee Name";
			this.colEmployeeName.ColumnEdit = this.repEmployees;
			this.colEmployeeName.FieldName = "EmployeeId";
			this.colEmployeeName.MinWidth = 30;
			this.colEmployeeName.Name = "colEmployeeName";
			this.colEmployeeName.Visible = true;
			this.colEmployeeName.VisibleIndex = 1;
			this.colEmployeeName.Width = 112;
			// 
			// repEmployees
			// 
			this.repEmployees.AutoHeight = false;
			this.repEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repEmployees.Name = "repEmployees";
			this.repEmployees.PopupView = this.gridView1;
			// 
			// gridView1
			// 
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// colCustomerName
			// 
			this.colCustomerName.Caption = "Customer Name";
			this.colCustomerName.ColumnEdit = this.repCustomers;
			this.colCustomerName.FieldName = "CustomerId";
			this.colCustomerName.MinWidth = 30;
			this.colCustomerName.Name = "colCustomerName";
			this.colCustomerName.Visible = true;
			this.colCustomerName.VisibleIndex = 2;
			this.colCustomerName.Width = 112;
			// 
			// repCustomers
			// 
			this.repCustomers.AutoHeight = false;
			this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repCustomers.Name = "repCustomers";
			this.repCustomers.PopupView = this.repositoryItemGridLookUpEdit1View;
			// 
			// repositoryItemGridLookUpEdit1View
			// 
			this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
			this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// colPaymentMethod
			// 
			this.colPaymentMethod.Caption = "Payment Method";
			this.colPaymentMethod.FieldName = "PaymentMethod";
			this.colPaymentMethod.MinWidth = 30;
			this.colPaymentMethod.Name = "colPaymentMethod";
			this.colPaymentMethod.Visible = true;
			this.colPaymentMethod.VisibleIndex = 3;
			this.colPaymentMethod.Width = 112;
			// 
			// colTotalValue
			// 
			this.colTotalValue.Caption = "Total Value";
			this.colTotalValue.FieldName = "TotalValue";
			this.colTotalValue.MinWidth = 30;
			this.colTotalValue.Name = "colTotalValue";
			this.colTotalValue.OptionsColumn.AllowEdit = false;
			this.colTotalValue.OptionsColumn.ReadOnly = true;
			this.colTotalValue.Visible = true;
			this.colTotalValue.VisibleIndex = 4;
			this.colTotalValue.Width = 112;
			// 
			// grdTransactionLines
			// 
			this.grdTransactionLines.Location = new System.Drawing.Point(12, 263);
			this.grdTransactionLines.MainView = this.grvTransactionLines;
			this.grdTransactionLines.Name = "grdTransactionLines";
			this.grdTransactionLines.Size = new System.Drawing.Size(856, 214);
			this.grdTransactionLines.TabIndex = 1;
			this.grdTransactionLines.UseEmbeddedNavigator = true;
			this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
			// 
			// grvTransactionLines
			// 
			this.grvTransactionLines.GridControl = this.grdTransactionLines;
			this.grvTransactionLines.Name = "grvTransactionLines";
			// 
			// Transactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 510);
			this.Controls.Add(this.grdTransactionLines);
			this.Controls.Add(this.grdTransactions);
			this.Name = "Transactions";
			this.Text = "Transactions";
			this.Load += new System.EventHandler(this.Transactions_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdTransactions;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
		private DevExpress.XtraGrid.Columns.GridColumn colDate;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
		private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
		private DevExpress.XtraGrid.GridControl grdTransactionLines;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repEmployees;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}